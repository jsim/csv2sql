using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace csv2sql {
    
    enum ColType {
        Text,
        Int,
        Date,
        Decimal
    }
    
    class ColumnInfo {
        public string Name { get; set; }
        public ColType ColumnType { get; set; }
        public int Index { get; set; }
    }
}
