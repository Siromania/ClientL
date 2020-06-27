using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Client.Model
{
    class Message
    {
        bool statusOp;
        string operationVersion;
        string appVersion;
        string operationName;
        string info;
        User user;
        object[] data;

        public Message(User u,string txt)
        {
            user = u;
            statusOp = false;
            operationVersion = "1";
            appVersion = "f12458d120e6d32cf89ee714d35c723d8caa1273c3bcdf1ba79c63df7329254a";
            operationName = "constructor";
            data[0] = txt;
        }

        public bool StatusOp { get => statusOp; set => statusOp = value; }
        public string OperationVersion { get => operationVersion; set => operationVersion = value; }
        public string AppVersion { get => appVersion; set => appVersion = value; }
        public string OperationName { get => operationName; set => operationName = value; }
        public string Info { get => info; set => info = value; }
        public object[] Data { get => data; set => data = value; }
        internal User User { get => user; set => user = value; }
    }
}
