using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Text;
using Microsoft.SqlServer.Server;

public partial class UserDefinedFunctions
{
    [Microsoft.SqlServer.Server.SqlFunction]
    public static SqlString ConvertEncoding(string inputString, string encodeFrom, string encodeTo)
    {
        var bytes = Encoding.GetEncoding(encodeFrom).GetBytes(inputString);
        string result = Encoding.GetEncoding(encodeTo).GetString(bytes);

        return new SqlString (result);
    }
}
