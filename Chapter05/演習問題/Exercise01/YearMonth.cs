using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    //5.1.1
    public class YearMonth {
        public int Year { get; set; }
        public int Month { get; init; }

        public YearMonth(int Year, int Month) {
            Year = Year;
            Month = Month;
        
        }
        public bool Is21Century => 2001 <= Year && Year <= 2100;
        //5.1.3
        public YearMonth AddOneMonth() {

            
        }
    }
}
