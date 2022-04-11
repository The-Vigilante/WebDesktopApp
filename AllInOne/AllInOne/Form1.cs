using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
using System.Net;
using System.Diagnostics;

namespace AllInOne
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Github Section.
        private async Task Initialize_Github()
        {
            await webViewgithub.EnsureCoreWebView2Async(null);
        }
        public async void InitBrowserGithub()
        {
            await Initialize_Github();
            webViewgithub.CoreWebView2.Navigate("https://github.com/");
        }

        //Youtube section
        private async Task Initialize_Youtube()
        {
            await webViewyoutube.EnsureCoreWebView2Async(null);
        }
        public async void InitBrowserYoutube()
        {
            await Initialize_Youtube();
            webViewyoutube.CoreWebView2.Navigate("https://www.youtube.com/");
        }

        //VS Code section
        private async Task Initialize_VScode()
        {
            await webViewvscode.EnsureCoreWebView2Async(null);
        }
        public async void InitBrowserVScode()
        {
            await Initialize_VScode();
            webViewvscode.CoreWebView2.Navigate("https://vscode.dev/");
        }

        //Stackoverflow section
        private async Task Initialize_Stack()
        {
            await webViewstack.EnsureCoreWebView2Async(null);
        }
        public async void InitBrowserStack()
        {
            await Initialize_Stack();
            webViewstack.CoreWebView2.Navigate("https://stackoverflow.com/");
        }

        //Discord section
        private async Task Initialize_Discord()
        {
            await webViewdiscord.EnsureCoreWebView2Async(null);
        }
        public async void InitBrowserDiscord()
        {
            await Initialize_Discord();
            webViewdiscord.CoreWebView2.Navigate("https://discord.com/channels/@me");
        }

        //Gmail section
        private async Task Initialize_Gmail()
        {
            await webViewgmail.EnsureCoreWebView2Async(null);
        }
        public async void InitBrowserGmail()
        {
            await Initialize_Gmail();
            webViewgmail.CoreWebView2.Navigate("https://www.gmail.com/");
        }

        //LinkedIn section
        private async Task Initialize_Linkdin()
        {
            await webViewlinkedin.EnsureCoreWebView2Async(null);
        }
        public async void InitBrowserLinkedin()
        {
            await Initialize_Linkdin();
            webViewlinkedin.CoreWebView2.Navigate("https://www.linkedin.com/");
        }

        //Google section
        private async Task Initialize_Google()
        {
            await webViewGoogle.EnsureCoreWebView2Async(null);
        }
        public async void InitBrowserGoogle()
        {
            await Initialize_Google();
            webViewGoogle.CoreWebView2.Navigate("https://www.google.com/");
        }

        //W3schools section
        private async Task Initialize_W3()
        {
            await webViewW3.EnsureCoreWebView2Async(null);
        }
        public async void InitBrowserW3()
        {
            await Initialize_W3();
            webViewW3.CoreWebView2.Navigate("https://www.w3schools.com/");
        }

        //Spotify section
        private async Task Initialize_Spotify()
        {
            await webViewSpotify.EnsureCoreWebView2Async(null);
        }
        public async void InitBrowserSpotify()
        {
            await Initialize_Spotify();
            webViewSpotify.CoreWebView2.Navigate("https://www.spotify.com/ma-fr/");
        }


        /*////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////*/


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGithub_Click(object sender, EventArgs e)
        {
            Book.SetPage("tabPage1");
        }

        private void btnYoutube_Click(object sender, EventArgs e)
        {
            Book.SetPage("tabPage2");
        }

        private void btnVSCODE_Click(object sender, EventArgs e)
        {
            Book.SetPage("tabPage3");
        }

        private void btnSTACK_Click(object sender, EventArgs e)
        {
            Book.SetPage("tabPage4");
        }

        private void btnDISCORD_Click(object sender, EventArgs e)
        {
            Book.SetPage("tabPage5");
        }

        private void btnGmail_Click(object sender, EventArgs e)
        {
            Book.SetPage("tabPage6");
        }

        private void btnLinkedin_Click(object sender, EventArgs e)
        {
            Book.SetPage("tabPage7");
        }
        private void btnGoogle_Click(object sender, EventArgs e)
        {
            Book.SetPage("tabPage8");
        }

        private void btnW3_Click(object sender, EventArgs e)
        {
            Book.SetPage("tabPage9");
        }

        private void btnSpotify_Click(object sender, EventArgs e)
        {
            Book.SetPage("tabPage10");
        }

        private void btnOn_Click(object sender, EventArgs e)
        {
            try
            {
                InitBrowserGithub(); InitBrowserYoutube(); InitBrowserVScode(); InitBrowserStack();
                InitBrowserDiscord(); InitBrowserGmail(); InitBrowserLinkedin(); InitBrowserGoogle();
                InitBrowserSpotify(); InitBrowserW3();
                Book.SetPage("tabPage8");
                btnOnn.Visible = false;
            }
            catch (Exception ex)
            {

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
