namespace Vision.DataModel
{
    public class DbStore
    {
        //public static string connectstring = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        //public static object GetScalarSQL(string sql)
        //{
        //    using (OracleConnection conn = new OracleConnection(connectstring))
        //    {
        //        conn.Open();
        //        OracleCommand da = conn.CreateCommand();
        //        try
        //        {
        //            da.CommandText = sql;
        //            return da.ExecuteScalar();
        //        }
        //        catch (Exception e)
        //        {
        //            CLog.Write(string.Format("WSDbWorks.GetSQL({0}) -> {1}", sql, e.GetAllMessages()));
        //        }
        //    }
        //    return null;
        //}

        //public static DataTable GetSQL(string sql)
        //{
        //    System.Data.DataTable result = new System.Data.DataTable();
        //    using (OracleConnection conn = new OracleConnection(connectstring))
        //    {
        //        conn.Open();
        //        OracleDataAdapter da = new OracleDataAdapter(sql, conn);
        //        try
        //        {
        //            da.Fill(result);
        //        }
        //        catch (Exception e)
        //        {
        //            CLog.Write(string.Format("WSDbWorks.GetSQL({0}) -> {1}", sql, e.GetAllMessages()));
        //        }
        //    }
        //    return result;
        //}

        //public static void InsTimeToPerson(Int64 Id)
        //{
        //    using (OracleConnection conn = new OracleConnection(connectstring))
        //    {
        //        conn.Open();
        //        try
        //        {

        //            var count = GetScalarSQL("SELECT COUNT(TB_ID) FROM TB_TIME WHERE TB_DATE BETWEEN TRUNC(SYSDATE) AND SYSDATE AND TB_PERSON = "+Id.ToStr());

        //            if (count.ToObjInt() == 0)
        //            {
        //                string sql = @"INSERT INTO TB_TIME (TB_ID ,TB_PERSON ,TB_DATE) VALUES (SQ_TIME.NEXTVAL, {0}, SYSDATE)";

        //                using (OracleCommand oc = conn.CreateCommand())
        //                {
        //                    oc.CommandText = String.Format(sql, Id);
        //                    oc.ExecuteNonQuery();
        //                }
        //            }
        //        }
        //        catch (Exception eee)
        //        {
        //            CLog.Write(eee.GetAllMessages());
        //        }
        //    }
        //}

        //public static void InsPerson(string name, List<Tuple<int, byte[]>> la)
        //{
        //    using (OracleConnection conn = new OracleConnection(connectstring))
        //    {
        //        conn.Open();
        //        OracleTransaction tran = conn.BeginTransaction();
        //        try
        //        {
        //            string id = DbStore.GetScalarSQL("SELECT TIME.SQ_PERSON.NEXTVAL	FROM DUAL").ToStr();
        //            string sql = @"INSERT INTO TIME.TB_PERSON (TB_ID,TB_CREATEDATE,TB_ACTIVE,TB_FIO, TB_TEXT) VALUES ({0}, SYSDATE, 1, {1}, {1} )";

        //            using (OracleCommand oc = conn.CreateCommand())
        //            {
        //                oc.CommandText = String.Format(sql, id, name.ToUpper().ToQuote());
        //                oc.ExecuteNonQuery();
        //            }

        //            sql = @"INSERT INTO TIME.TB_IMAGES (TB_ID,TB_IMAGE,TB_TYPE,TB_PERSON)VALUES(SQ_IMAGES.NEXTVAL, :IMG, {0}, {1})";
        //            using (OracleCommand ob = conn.CreateCommand())
        //            {
        //                OracleParameter blobParameter = ob.Parameters.Add("IMG", OracleDbType.Blob, ParameterDirection.Input);
        //                foreach (Tuple<int, byte[]> item in la)
        //                {
        //                    ob.CommandText = String.Format(sql, item.Item1, id);
        //                    blobParameter.Value = item.Item2;
        //                    ob.ExecuteNonQuery();
        //                }
        //            }
        //            tran.Commit();
        //        }
        //        catch (Exception eee)
        //        {
        //            CLog.Write(eee.GetAllMessages());
        //            tran.Rollback();
        //        }
        //    }
        //}

        //public static List<TimePerson> GetTimePersons(string where)
        //{
        //    List<TimePerson> fdb = new List<TimePerson>();

        //    using (OracleConnection conn = new OracleConnection(connectstring))
        //    {
        //        conn.Open();
        //        var sql = "SELECT TB_DATE,TB_FIO,TB_IMAGE, TD FROM TIME.VI_PERSON_TIME " + where;
        //        OracleCommand da = new OracleCommand(sql, conn);
        //        OracleDataReader dr = da.ExecuteReader();

        //        while (dr.Read())
        //        {
        //            TimePerson p = new TimePerson();
        //            p.WTime = dr.GetDateTime(0).ToString();
        //            p.Name = dr.GetString(1);
        //            p.Td = dr.GetOracleDate(3).Value;

        //            if (dr.GetValue(2) != DBNull.Value)
        //            {
        //                OracleBlob ob = dr.GetOracleBlob(2);
        //                if (ob != null)
        //                {
        //                    p.Photo = CImage.ByteArrayToImage(ob.Value);
        //                }
        //            }

        //            fdb.Add(p);
        //        }
        //    }
        //    return fdb;
        //}

        //public static List<MyPerson> GetPersons()
        //{
        //    List<MyPerson> fdb = new List<MyPerson>();

        //    byte[] buffer = new byte[1];
        //    using (OracleConnection conn = new OracleConnection(connectstring))
        //    {
        //        conn.Open();
        //        var sql = "SELECT * FROM TIME.VI_PERSON";
        //        OracleCommand da = new OracleCommand(sql, conn);
        //        OracleDataReader dr = da.ExecuteReader();

        //        var sqlImg = "SELECT TB_IMAGE FROM TIME.TB_IMAGES WHERE TB_PERSON=:ID and TB_TYPE=2";
        //        OracleCommand dci = new OracleCommand(sqlImg, conn);
        //        var ipr = dci.Parameters.Add("ID", OracleDbType.Int64, ParameterDirection.Input);

        //        while (dr.Read())
        //        {
        //            MyPerson p = new MyPerson();
        //            p.Id = dr.GetInt64(0);
        //            p.Name = dr.GetString(1);
        //            p.Text = dr.GetString(6);

        //            if (dr.GetValue(5) != DBNull.Value)
        //            {
        //                OracleBlob ob = dr.GetOracleBlob(5);
        //                if (ob != null)
        //                {
        //                    p.Photo = ob.Value;
        //                }
        //            }

        //            ipr.Value = p.Id;
        //            OracleDataReader dri = dci.ExecuteReader();
        //            p.Fingerprints = new List<Fingerprint>();

        //            while (dri.Read())
        //            {
        //                if (dri.GetValue(0) != DBNull.Value)
        //                {
        //                    OracleBlob ob = dri.GetOracleBlob(0);
        //                    if (ob != null)
        //                    {
        //                        Fingerprint fp = new Fingerprint();
        //                        fp.AsBitmap = CImage.ByteArrayToImage(ob.Value) as Bitmap;
        //                        p.Fingerprints.Add(fp);
        //                    }
        //                }
        //            }


        //            fdb.Add(p);
        //        }
        //    }
        //    return fdb;
        //}
    }
}
