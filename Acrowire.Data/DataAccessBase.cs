using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acrowire.Data
{
    public partial class DataAccessBase
    {

        #region [ Fields ] 
        private SqlDataAccess m_access;
        #endregion

        #region [ Properies ]
        public String ConnectionStringName { get; private set; }

        public SqlDataAccess Access { get; set; }
        #endregion

        #region [ Constructors ]
        public DataAccessBase()
        {
            this.ConnectionStringName = "default";
            this.Access = new SqlDataAccess(this.ConnectionStringName);
        }

        #endregion

    }
}
