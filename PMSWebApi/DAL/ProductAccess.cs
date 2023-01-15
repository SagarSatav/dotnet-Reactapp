namespace PMSWebApi.DAL;
using PMSWebApi.Model;
using System.Data;
using MySql.Data.MySqlClient;


public class ProductAccess
{
    public static string conString = @"server=localhost; port=3306; user=root;password=root@123; database=product";

    public static List<Product> GetAllProduct()
    {
        List<Product> allProd = new List<Product>();
        MySqlConnection con = new MySqlConnection(conString);

        try
        {
            con.Open();
            string query = "select * from product";
            DataSet ds = new DataSet();
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(ds);

            DataTable dt = ds.Tables[0];
            DataRowCollection rows = dt.Rows;
            foreach (DataRow row in rows)
            {
                Product product = new Product
                {
                    pid = int.Parse(row["pid"].ToString()),
                    pname = row["pname"].ToString(),
                    purchasedate = row["purchasedate"].ToString()
                };
                allProd.Add(product);
            }

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            con.Close();
        }
        return allProd;
    }

    public static void SaveProduct(Product product)
    {
        MySqlConnection con = new MySqlConnection(conString);
        try
        {
            con.Open();
            string query = $"insert into product(pname,purchasedate) values ('{product.pname}','{product.purchasedate}')";
            MySqlCommand command = new MySqlCommand(query, con);
            command.ExecuteNonQuery();
            con.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            con.Close();
        }
    }

    public static void DeleteProductById(int id)
    {
        MySqlConnection con = new MySqlConnection(conString);
        try
        {
            con.Open();
            string query = "delete from product where pid= "+id;
            MySqlCommand command = new MySqlCommand(query, con);
            command.ExecuteNonQuery();
            con.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            con.Close();
        }
    }

    
    public static void UpdateProductById(Product product)
    {
        MySqlConnection con = new MySqlConnection(conString);
    
        try
        {
            con.Open();
            string query = "update product set pname='" + product.pname + "', purchasedate='" + product.purchasedate + "' where pid=" + product.pid;
            MySqlCommand command = new MySqlCommand(query, con);
            command.ExecuteNonQuery();
            con.Close();

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            con.Close();
        }
    }



}


