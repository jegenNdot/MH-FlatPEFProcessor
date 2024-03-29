﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MH.PEF.BLL
{
    public static class MyDataTableExtensions
    {
        public static void WriteToCsvFile(this DataTable dataTable, string filePath)
        {
            var filecount = "01";
            var FileName = "PEFExtract-" + filecount +".csv";
           var fullpath =  filePath + FileName;
            StringBuilder fileContent = new StringBuilder();

            foreach (var col in dataTable.Columns)
            {
                fileContent.Append(col.ToString() + ",");
            }

            fileContent.Replace(",", System.Environment.NewLine, fileContent.Length - 1, 1);

            foreach (DataRow dr in dataTable.Rows)
            {
                foreach (var column in dr.ItemArray)
                {
                    fileContent.Append("\"" + column.ToString() + "\",");
                }

                fileContent.Replace(",", System.Environment.NewLine, fileContent.Length - 1, 1);
            }

            System.IO.File.WriteAllText(fullpath, fileContent.ToString());
        }
    }
}
