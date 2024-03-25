using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace LTimer
{
    internal class XmlRW
    {
        /// <summary>
        /// コンストラクタ - なし
        /// </summary>
        public XmlRW()
        {
                // TODO: コンストラクタのロジックをここに追加
        }

        public DataSet SetXML(string xmlFile)
        {
           try
            {
                DataSet xmlDS = new DataSet();

                xmlDS.ReadXml(xmlFile);
                return xmlDS;
            }
            catch
            {
                throw new ApplicationException("@NotFoundFile");
            }
        }

        public DataSet SetXML(string xmlFile, string xmlschemaFile)
        {
            DataSet xmlDS = new DataSet();
 
            xmlDS.ReadXml(xmlFile);
            xmlDS.ReadXmlSchema(xmlschemaFile);
            return xmlDS;
        }
 
        public void SaveXML(DataSet ds, string xmlFile)
        {
            try
            {
                ds.WriteXml(xmlFile);
            }
            catch
            {
                throw new ApplicationException("@NotCreateFile");
            }
        }
 
        public void SaveXMLSchema(DataSet ds, string xmlschemaFile)
        {
            ds.WriteXmlSchema(xmlschemaFile);
        }
 
        public string GetKey(DataTable dt, string keyName, string key, string returnKey)
        {
            try
            {
                DataTable myTable = dt;
                DataView myView = new DataView(myTable);
                myView.RowFilter = keyName + "='" + key + "'";
                DataRowView myRow = (DataRowView)myView[0];
                string keyValue = myRow[returnKey].ToString();
 
                return keyValue;
            }
            catch
            {
                throw new ApplicationException("@NotGetKeyValue");
            }
        }
 
        public DataSet loadXmlFile(string _path, string ErrMessage)
        {
            try
            {
                DataSet _ds = SetXML(_path);
                return _ds;
            }
            catch
            {
                throw new ApplicationException(ErrMessage);
            }
         }

        public DataSet loadXmlFile(string _path, string _shmPath, string ErrMessage)
        {
             try
             {
                 DataSet _ds = SetXML(_path, _shmPath);
                 return _ds;
             }
             catch
             {
                 throw new ApplicationException(ErrMessage);
             }
        }
    }
}
