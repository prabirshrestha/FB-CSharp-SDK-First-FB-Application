using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Facebook;

namespace FirstFacebookApplication
{
    public partial class FacebookLoginDialog : Form
    {
        private Uri navigateUrl;

        public FacebookLoginDialog(string appId, string[] extendedPermissions)
        {
            var oauth = new FacebookOAuthClient { AppId = appId };

            var loginParameters = new Dictionary<string, object>
                    {
                        { "response_type", "token" },
                        { "display", "popup" }
                    };

            if (extendedPermissions != null && extendedPermissions.Length > 0)
            {
                var scope = new StringBuilder();
                scope.Append(string.Join(",", extendedPermissions));
                loginParameters["scope"] = scope.ToString();
            }

            var loginUrl = oauth.GetLoginUrl(loginParameters);

            this.navigateUrl = loginUrl;

            InitializeComponent();
        }

        private void FacebookLoginDialog_Load(object sender, EventArgs e)
        {
            webBrowser.Navigate(this.navigateUrl.AbsoluteUri);
        }

        private void webBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            FacebookOAuthResult result;
            if (FacebookOAuthResult.TryParse(e.Url, out result))
            {
                this.FacebookOAuthResult = result;
                this.DialogResult = result.IsSuccess ? DialogResult.OK : DialogResult.No;
            }
            else
            {
                this.FacebookOAuthResult = null;
            }
        }

        public FacebookOAuthResult FacebookOAuthResult { get; private set; }
    }
}