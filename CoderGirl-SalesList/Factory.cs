using System;
using System.Collections.Generic;
using System.Text;

namespace CoderGirl_SalesList
{
    public class Factory
    {
        public ISalesRecordAdapter SalesRecordAdapter { get; private set; }
        public ISalesRecordAnalyzer SalesRecordAnalyzer { get; private set; }
        public ISalesRecordRepository SalesRecordRepository { get; private set; }

        public Factory()
        {
            this.SalesRecordAdapter = new SalesRecordAdapter();
            this.SalesRecordAnalyzer = new SalesRecordAnalyzer();
            this.SalesRecordRepository = new SalesRecordRepository();
            
            //TODO: Add specific implementation classes

            //this.SalesRecordAnalyzer = new ??
            //this.SalesRecordAdapter = new ??
        }
    }
}
