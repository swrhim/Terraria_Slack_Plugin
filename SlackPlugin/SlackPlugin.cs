using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdsm.api;
using tdsm.api.Plugin;


namespace SlackPlugin
{
    public class SlackPlugin : BasePlugin
    {
        public SlackPlugin() {
            this.TDSMBuild = 1;
            this.Version = "1";
            this.Author = "swrhim";
            this.Name = "Slack Notification Plugin";
            this.Description = "This plugin will notify a slack channel of users logging in and out";
        }

        [Hook(HookOrder.NORMAL)]
        void AlertSignIn(ref HookContext ctx, ref HookArgs.PlayerEnteredGame args) {
            

        }

    }
}
