using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Collections;
using System.Data.SqlClient;
using Quan_Ly_Kho.APP_DATA;
using System.Windows.Forms;

namespace Quan_Ly_Kho
{
    public class HANGHOADATA : APP_DATA.DATA
    {
     public HANGHOADATA()
     {
         base.path = "select * from HANGHOA";
     }
     public void GAN_HH(List<String> HH)
     {
         cmd.Parameters.AddWithValue("@ID", HH[0]);
         cmd.Parameters.AddWithValue("@NAME", HH[1]);
         cmd.Parameters.AddWithValue("@GIA", HH[2]);
         cmd.Parameters.AddWithValue("@IDNSX", HH[3]);
         
     }

     public void InsertHH(List<string> HH)
     {
         //CHECK = 0;
         //base.sql = "INSERTHANGHOA";
         //SP_DATA();
         //GAN_HH(HH);
         //check();
         SqlConnection connect = new SqlConnection(@"Data Source=LAPTOP-9DMN1VK3\SQLEXPRESS;Initial Catalog=QUAN_LY_KHO;Integrated Security=True");
         SqlDataAdapter da = new SqlDataAdapter(cmd);//lưu dữ liệu lấy được vào đây
         //string sSql = "INSERT INTO GiaoVien VALUES (ID_GiaoVien='"+GV[0]+"',TenGV='" + GV[1] + "',SDT=" + GV[2] + ",Email='" + GV[3] + "',GT='" + GV[4] + "',HocHam='" + GV[5] + "',HocVi='" + GV[6]="')";
         string sSql = "INSERT INTO HANGHOA VALUES ('" + HH[0] + "','" + HH[1] + "'," + HH[2] + ",'" + HH[3] + "')";

         da.InsertCommand = new SqlCommand(sSql, connect);
         connect.Open();
         da.InsertCommand.ExecuteNonQuery();
         connect.Close();
         MessageBox.Show("Thêm hàng hóa" + HH[0] + " thành công");
        }
     public void UpdateHH(List<String> HH)
     {
            //CHECK = 0;
            //base.sql = "UPDATEHANGHOA";
            //SP_DATA();
            //GAN_HH(HH);
            //check();
            SqlConnection connect = new SqlConnection(@"Data Source=LAPTOP-9DMN1VK3\SQLEXPRESS;Initial Catalog=QUAN_LY_KHO;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter(cmd);//lưu dữ liệu lấy được vào đây
                                                        //string sSql = "INSERT INTO GiaoVien VALUES (ID_GiaoVien='"+GV[0]+"',TenGV='" + GV[1] + "',SDT=" + GV[2] + ",Email='" + GV[3] + "',GT='" + GV[4] + "',HocHam='" + GV[5] + "',HocVi='" + GV[6]="')";
            string sSql = "UPDATE HANGHOA SET TenHangHoa'" + HH[1] + "' WHERE ID_HangHoa='" + HH[0] + "'";

            da.InsertCommand = new SqlCommand(sSql, connect);
            connect.Open();
            da.InsertCommand.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Cập nhật hàng hóa có ID " + HH[0] + " thành công");

        }
     public void DeleteHH(string ID)
     {
            //base.sql = "DELETEHANGHOA";
            //SP_DATA();
            //cmd.Parameters.AddWithValue("@ID", ID);
            //cmd.ExecuteNonQuery();
            //cmd.Dispose();
            //con.Close();
            SqlConnection connect = new SqlConnection(@"Data Source=LAPTOP-9DMN1VK3\SQLEXPRESS;Initial Catalog=QUAN_LY_KHO;user id=sa;password=123456;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter(cmd);//lưu dữ liệu lấy được vào đây
                                                        //string sSql = "INSERT INTO GiaoVien VALUES (ID_GiaoVien='"+GV[0]+"',TenGV='" + GV[1] + "',SDT=" + GV[2] + ",Email='" + GV[3] + "',GT='" + GV[4] + "',HocHam='" + GV[5] + "',HocVi='" + GV[6]="')";
            string sSql = "Delete from HANGHOA where ID_HANGHOA='" + ID + "'";

            da.InsertCommand = new SqlCommand(sSql, connect);
            connect.Open();
            da.InsertCommand.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Xóa hàng hóa có ID " + ID + " thành công");
        }
    }
}
