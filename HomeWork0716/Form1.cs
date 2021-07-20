using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork0716
{
    public partial class Form1 : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        public Form1()
        { 
            InitializeComponent();
            random = new Random();
            btnCloseChildForm.Visible = false;
            this.Text = string.Empty;     //移除視窗上控制條
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea; //Indicate the limits of the maximized(equal to the working area)
        }


        #region 視窗拖曳用DllImport
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]//Dll進入點
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion

        #region 選單按鈕主題顏色變化設定(設定詳情請參考ThemeColor.cs)
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count); // 以防Infinite Loop
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        #endregion

        #region 選單按鈕Enable回饋設定
        private void ActivateButton(object btnsender)
        {
            if(btnsender != null)
            {
                if(currentButton != (Button)btnsender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnsender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("微軟正黑體", 14.5F, System.Drawing.FontStyle.Bold);
                    PnTitleBar.BackColor = color;
                    PicLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btnCloseChildForm.Visible = true;

                }
            }    
        }

        #endregion 

        #region 選單按鈕Disable回饋設定
        private void DisableButton()
        {
            foreach (Control previousBtn in PnMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold);
                }
            }
        }

        #endregion
 
        #region 選單按鈕子表單導入設定
        private void btn1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormCMS(), sender);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormCMS(), sender);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormCMS(), sender);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormCMS(), sender);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormCMS(), sender);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormCMS(), sender);
        }

        private void btnCoculator_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormCalculator(), sender);
        }
        #endregion

        #region 子表單呼叫設定
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.PnDeskTop.Controls.Add(childForm);
            this.PnDeskTop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;

        }
        #endregion

        #region WebBrowser設定
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            var embed = "<html><head>" +
            "<meta http-equiv=\"X-UA-Compatible\" content=\"IE=Edge\"/>" +
            "</head><body>" +
            "<iframe width=\"360\" height=\"280\" src=\"{0}\"" +
            "frameborder = \"0\" allow = \"autoplay; encrypted-media\" allowfullscreen></iframe>" +
            "</body></html>";
            var url = "https://www.youtube.com/embed/_ZF3xMEzkcg";
            this.webBrowser1.DocumentText = string.Format(embed, url);
        }
        #endregion

        #region 視窗個功能按鈕設定
        private void PnTitleBar_MouseDown(object sender, MouseEventArgs e) //設定MouseDown時可拖曳視窗
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e) //關閉視窗紐設定
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e) //視窗模式及一般模式切換
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal; 
            }
               
     
        }

        private void btnMinimize_Click(object sender, EventArgs e) //縮小視窗
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCloseChildForm_Click(object sender, EventArgs e) //設定關閉子表單按鈕
        {
            if (activeForm != null) //上面有寫到
                activeForm.Close();
            Reset();
        }
        private void Reset()
        {
            DisableButton();
            lblTitle.Text = "稅務專區";
            PnTitleBar.BackColor = Color.FromArgb(51, 51, 76);
            PnLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            btnCloseChildForm.Visible = false;
            PnLogo.BackColor = Color.FromArgb(39, 39, 58);
        }
        #endregion
    }
}
