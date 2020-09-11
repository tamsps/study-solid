using System;
using System.Collections.Generic;
using System.Text;

namespace LearnSOLID
{
    public class CustomerDAL
    {
        private ILogger _logger;
        public List<string> cusList;
        public CustomerDAL(ILogger logger)
        {
            _logger = logger;
        }

        public void InsertCustomer()
        {
            try
            {
                cusList.Add("Vu Cong Tam");
            }
            catch(Exception ex)
            {
                _logger.LogError(ex);
            }
        }
    }
}
