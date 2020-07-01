using Client.ServiceReference2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Client.Model
{
    class STGClient : STG
    {
        bool statusOp;
        string operationVersion;
        string appVersion;
        string operationName;
        string info;
        string tokenUser;
        string tokenApp;
        object[] data;

        public STGClient(bool statusOp, string operationVersion, string appVersion, string operationName, string info, string tokenUser, string tokenApp, object[] data)
        {
            this.statusOp = statusOp;
            this.operationVersion = operationVersion;
            this.appVersion = appVersion;
            this.operationName = operationName;
            this.info = info;
            this.tokenUser = tokenUser;
            this.tokenApp = tokenApp;
            this.data = data;
        }
    }
}
