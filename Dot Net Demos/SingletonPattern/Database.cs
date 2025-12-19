using FactoryPatternPractice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    internal abstract class Database
    {
        protected Logger _logger = null;
        public Database()
        {
            _logger = Logger.GetMyLogger();
        }

        protected abstract void DoInsert();
        protected abstract void DoUpdate();
        protected abstract void DoDelete();
        protected abstract void DoCreate();
        protected abstract string GetDataBaseName();

        public void Insert()
        {
            DoInsert();
            _logger.Log($"Inserted from {GetDataBaseName()} done.");
        }

        public void Update()
        {
            DoUpdate();
            _logger.Log($"Updated from {GetDataBaseName()} done.");
        }

        public void Delete()
        {
            DoDelete();
            _logger.Log($"Deleted from {GetDataBaseName()} done.");
        }

        public void Create()
        {
            DoCreate();
            _logger.Log($"Created in {GetDataBaseName()} done.");
        }

    }
}
