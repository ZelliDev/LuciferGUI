/// TRichTextBox
/// Copyright@Trestan Chen,Canada. 2010.
/// this code is provided as is, bugs are probable, free for any use, no responsibility accepted :-)
/// Please contact trestan88@yahoo.ca,for any questions and suggestions.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;

namespace Trestan
{
    class TRichTextBox : RichTextBox
    {
        // The following settings can be changed to read from configuration file.
        const int MaximumTextLength = 10000;
        const int TextLengthToBeRemoved = 3000;
        const int MaximumNoOfControl = 50;
        const int NoOfControlToBeRemoved = 20;
        bool KeepShort = true;

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hwnd, Int32 wMsg, Int32 wParam, ref Point pt);
        const int EM_GETSCROLLPOS = 0x0400 + 221;

        List<MetaInfo> ControlList = new List<MetaInfo>();

        public TRichTextBox()
            : base()
        {
            this.VScroll += new EventHandler(TRichTextBox_VScroll);
            this.SizeChanged += new EventHandler(TRichTextBox_SizeChanged);
            this.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.TRichTextBox_LinkClicked);
        }

        //Contains the initial position data of a control relative to the text content.
        internal class MetaInfo
        {
            int charIndex;
            public int CharIndex
            {
                get { return charIndex; }
                set { charIndex = value; }
            }

            int deltaY;
            public int DeltaY
            {
                get { return deltaY; }
                set { deltaY = value; }
            }

            Control theControl;
            public Control TheControl
            {
                get { return theControl; }
                set { theControl = value; }
            }

            public MetaInfo(Control theControl)
            {
                this.theControl = theControl;
            }

        }

        public void AddControl(Control oneControl)
        {
            // Obtain the initial metadata.
            MetaInfo one = new MetaInfo(oneControl);
            base.Controls.Add(oneControl);
            one.CharIndex = this.TextLength;
            one.TheControl.Location = this.GetPositionFromCharIndex(one.CharIndex);
            one.DeltaY = this.GetPositionFromCharIndex(0).Y - one.TheControl.Location.Y;
            ControlList.Add(one);

            //"Push" the text away from the space occupied by the control.
            do
            {
                this.AppendText(Environment.NewLine);
            }
            while (this.GetPositionFromCharIndex(this.TextLength).Y < (oneControl.Location.Y + oneControl.Height));

            RemoveSome();
            AutoScroll();
        }

        public void AutoScroll()
        {
            this.SelectionStart = this.TextLength - 1;
            this.ScrollToCaret();
        }

        private void RemoveSome()
        {
            //Optional. 
            //Remove some text and control if too many, to release system resources and improve performance.
            if (!KeepShort)
            {
                return;
            }

            int texttoRemove = 0;
            int imgtoRemove = 0;
            try
            {
                if (this.TextLength > MaximumTextLength)
                {
                    texttoRemove = TextLengthToBeRemoved;
                    this.Text = this.Text.Substring(texttoRemove);
                    texttoRemove += this.Text.IndexOf("\n");
                    if (texttoRemove > TextLengthToBeRemoved)
                    {
                        this.Text = this.Text.Substring(texttoRemove - TextLengthToBeRemoved);
                    }

                    foreach (MetaInfo oldone in ControlList)
                    {
                        if (oldone.CharIndex < texttoRemove)
                        {
                            imgtoRemove++;
                        }
                        else
                        {
                            oldone.CharIndex -= texttoRemove;
                        }
                    }

                    for (int i = 0; i < imgtoRemove; i++)
                    {
                        this.Controls[0].Dispose();
                        ControlList.RemoveAt(0);
                    }
                    //need to calculate the metadata again.
                    CalculateDelta();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            try
            {
                if (ControlList.Count > MaximumNoOfControl)
                {
                    imgtoRemove = NoOfControlToBeRemoved;
                    for (int i = 0; i < imgtoRemove; i++)
                    {
                        texttoRemove = ControlList[0].CharIndex;
                        ControlList.RemoveAt(0);
                        this.Controls[0].Dispose();
                    }
                    this.Text = this.Text.Substring(texttoRemove);
                    foreach (MetaInfo oldone in ControlList)
                    {
                        oldone.CharIndex -= texttoRemove;
                    }
                    //need to calculate the metadata again.
                    CalculateDelta();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void TRichTextBox_VScroll(object sender, EventArgs e)
        {
            Point pt = new Point();
            SendMessage(this.Handle, EM_GETSCROLLPOS, 0, ref pt);

            foreach (MetaInfo one in ControlList)
            {
                one.TheControl.Location = new Point(one.TheControl.Location.X, -pt.Y - one.DeltaY);
            }
        }

        private void TRichTextBox_SizeChanged(object sender, EventArgs e)
        {
            CalculateDelta();
        }

        private void CalculateDelta()
        {
            foreach (MetaInfo one in ControlList)
            {
                one.TheControl.Location = this.GetPositionFromCharIndex(one.CharIndex);
                one.DeltaY = this.GetPositionFromCharIndex(0).Y - one.TheControl.Location.Y;
            }
        }

        private void TRichTextBox_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }
    }

    class Utility
    {

        //Bonus. A simple check on the GIF files because some may contain "bad" data and crash the program.
        public static bool isImageCorrupted(Image img)
        {
            bool itis = false;

            try
            {
                if (!ImageAnimator.CanAnimate(img))
                {
                    return itis;
                }
                int frames = img.GetFrameCount(System.Drawing.Imaging.FrameDimension.Time);
                if (frames <= 1)
                {
                    return itis;
                }
                byte[] times = img.GetPropertyItem(0x5100).Value;
                int frame = 0;
                for (; ; )
                {
                    int dur = BitConverter.ToInt32(times, 4 * frame);
                    if (++frame >= frames) break;
                    img.SelectActiveFrame(System.Drawing.Imaging.FrameDimension.Time, frame);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return itis;
        }
    }
}
