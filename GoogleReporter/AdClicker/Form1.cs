using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdClicker
{

    public partial class Form1 : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        public int index = 0;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public bool isWorkerWorking = false;
        public string useragentString = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/94.0.4606.81 Safari/537.36";
        public string androidUserAgent = "Mozilla/5.0 (Linux; U; Android 4.4.2; en-us; SCH-I535 Build/KOT49H) AppleWebKit/534.30 (KHTML, like Gecko) Version/4.0 Mobile Safari/534.30";
        public string desktopUserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/94.0.4606.81 Safari/537.36";

        public Form1()
        {
            InitializeComponent();
        }

        public void setUserAgent(string value)
        {
            this.useragentString = value;
            this.useragent.Text = useragentString.Substring(0, 30) + "...";
        }

        public bool IsNumeric(string value)
        {
            return value.All(char.IsNumber);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void metroSetTextBox1_Enter(object sender, EventArgs e)
        {
            if (keyword.Text == "Kelime")
            {
                keyword.Text = "";
            }
        }

        private void metroSetTextBox2_Enter(object sender, EventArgs e)
        {
        }

        private void metroSetTextBox1_Leave(object sender, EventArgs e)
        {

        }

        private void metroSetDefaultButton1_Click(object sender, EventArgs e)
        {
            if (startButton.Text == "Başlat")
            {
                startButton.Text = "Durdur";
                status.Text = "Çalışıyor";
                loading.Visible = true;
                doWork.Interval = 250;
                changeUserAgent.Interval = Convert.ToInt32(changeVersionTimer.Value) * 1000;
                doWork.Enabled = true;
                changeUserAgent.Enabled = true;
                if (onlyDesktop.Checked == true)
                {
                    setUserAgent(desktopUserAgent);
                }
                if (onlyMobile.Checked == true)
                {
                    setUserAgent(androidUserAgent);
                }
            } else
            {
                startButton.Text = "Başlat";
                status.Text = "Bekliyor";
                loading.Visible = false;
                doWork.Enabled = false;
                changeUserAgent.Enabled = false;
                worker.CancelAsync();
            }
        }

        private void changeUserAgent_Tick(object sender, EventArgs e)
        {
            if (onlyDesktop.Checked == true)
            {
                setUserAgent(androidUserAgent);
            } else if (onlyMobile.Checked == true)
            {
                setUserAgent(desktopUserAgent);
            } else
            {
                if (useragentString == androidUserAgent)
                {
                    setUserAgent(androidUserAgent);
                }
                else
                {
                    setUserAgent(desktopUserAgent);
                }
            }
        }

        private void onlyMobile_CheckedChanged(object sender)
        {
            if (onlyMobile.Checked == true)
            {
                onlyDesktop.Checked = false;
            }
        }

        private void onlyDesktop_CheckedChanged(object sender)
        {
            if (onlyDesktop.Checked == true)
            {
                onlyMobile.Checked = false;
            }
        }

        private void doWork_Tick(object sender, EventArgs e)
        {
            if (isWorkerWorking == false && worker.IsBusy == false)
            {
                worker.RunWorkerAsync();
            }
        }

        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            isWorkerWorking = true;
            By searchBox = By.XPath("//input[@name='q']");
            By searchButtonMobile = By.XPath("//input[@name='btnG']");
            By targetElement = By.XPath("//a[string-length(@data-pcu) > 0]");
            By reportButton = By.XPath("//div[@role='button' and @aria-label='Site işlemleri']");
            By istismarButton = By.XPath("//span[@aria-label='İstismarı bildir']");
            By tumSiteButton = By.XPath("//div[@role='button' and @title='Tüm siteyi kötüye kullanım amaçlı olarak bildir']");
            By kimlikAviButton = By.XPath("//div[@role='button' and @aria-label='Spam, kötü amaçlı yazılım veya kimlik avı']");
            By bittiButton = By.XPath("//div[@role='button' and @aria-label='Bitti']");

            IWebDriver driver = null;
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--window-size=500,800");
            List<string> urls = new List<string>();

            if (useragentString == androidUserAgent)
            {
                options.AddArgument("user-agent=" + useragent);
            }
            try
            {
                driver = new ChromeDriver(options);
                driver.Navigate().GoToUrl("https://google.com");

                driver.FindElement(searchBox).Click();
                driver.FindElement(searchBox).SendKeys(keywordList.Items[index].ToString());
                if (useragentString == androidUserAgent)
                {
                    driver.FindElement(searchButtonMobile).Click();
                }
                if (useragentString == desktopUserAgent)
                {
                    driver.FindElement(searchBox).SendKeys(OpenQA.Selenium.Keys.Enter);
                }
                foreach (var item in driver.FindElements(targetElement))
                {
                    if (item.GetAttribute("href").Contains("http://localhost") || item.GetAttribute("href").Contains("https://localhost"))
                    {
                        continue;
                    }
                    urls.Add(item.GetAttribute("href"));
                }

                urls.RemoveAll(x => x.Contains("http://localhost"));
                urls.RemoveAll(x => x.Contains("https://localhost"));


            }
            catch (Exception)
            {
            }


            for (int i = 0; i < urls.Count; i++)
            {
                driver.Navigate().GoToUrl(urls[i]);
                if (driver.FindElements(reportButton).Count < 1)
                {
                    continue;
                }
                driver.FindElement(reportButton).Click();
                System.Threading.Thread.Sleep(Convert.ToInt32(1) * 2000);
                driver.FindElement(istismarButton).Click();
                System.Threading.Thread.Sleep(Convert.ToInt32(1) * 2000);
                driver.FindElements(tumSiteButton)[1].Click();
                System.Threading.Thread.Sleep(Convert.ToInt32(1) * 5000);
                driver.FindElement(kimlikAviButton).Click();
                System.Threading.Thread.Sleep(Convert.ToInt32(1) * 2000);
                driver.FindElement(bittiButton).Click();
                System.Threading.Thread.Sleep(Convert.ToInt32(1) * 2000);
                clickCount.Text = Convert.ToString(Convert.ToInt32(clickCount.Text) + 1);
            }


            index += 1;
            if (keywordList.Items.Count <= index)
            {
                index = 0;
                status.Text = "Tekrar";
                driver.Quit();
                isWorkerWorking = false;
                worker.CancelAsync();
            }
            else
            {
                driver.Quit();
                isWorkerWorking = false;
                worker.CancelAsync();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form1.CheckForIllegalCrossThreadCalls = false;
            this.AcceptButton = addButton;
            keywordList.AllowDrop = true;
            keywordList.DragEnter += keywordList_DragEnter;
        }


        private void addButton_Click(object sender, EventArgs e)
        {
            if (!keywordList.Items.Contains(keyword.Text) && keyword.Text != "")
            {
                keywordList.Items.Add(keyword.Text);
                keyword.Text = "";
            }
        }

        private void keywordList_DragDrop(object sender, DragEventArgs e)
        {
            string[] file = (string[])e.Data.GetData(DataFormats.FileDrop);
            keywordList.Items.AddRange(File.ReadAllLines(file[0]));
        }

        private void keywordList_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }
    }
}
