package colb.clob;

import java.io.File;
import java.io.FileInputStream;
import java.io.FileWriter;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.io.Reader;
import java.io.Writer;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.Statement;

public class JDBCClob {
	


	private static final String URL="jdbc:mysql://localhost:3306/hxh";
	private static final String username="root";
	private  static final String pwd="617662163";
	static Connection connection;
	static PreparedStatement pstmt;
	static ResultSet rs;
	
 public static void update() throws Exception
 {
	 Class.forName("com.mysql.jdbc.Driver");
	 connection= DriverManager.getConnection(URL, username, pwd);
	 String sql="insert into mynovel value(?,?)";
	 pstmt = connection.prepareStatement(sql);//Ԥ����
	 pstmt.setInt(1, 2); //����һ��������id1
	 File file=new File("a.txt");
	 InputStream in =new FileInputStream(file);
	 Reader reader=new InputStreamReader(in,"UTF-8");
	 pstmt.setCharacterStream(2, reader, (int)file.length());//���ڶ��������Ÿ�С˵
	 
	 int count=pstmt.executeUpdate();
	 if(count>0)
	 {
		 System.out.println("����ɹ�");
	 }
	if(reader!=null) reader.close();
	if(pstmt!=null) pstmt.close();
	if(connection!=null) connection.close();
	}
 
 
 public static void select() throws Exception
 {
	 Class.forName("com.mysql.jdbc.Driver");
	 connection= DriverManager.getConnection(URL, username, pwd);
	 String sql="select* from mynovel where id=?";
	 pstmt = connection.prepareStatement(sql);//Ԥ����
	 pstmt.setInt(1, 2); //����һ��������id1
	 rs = pstmt.executeQuery();
	 if (rs.next()) {
         Reader reader = rs.getCharacterStream("novel");
         Writer writer = new FileWriter("src/С˵.txt");
         char[] chs = new char[100];

         int len;
         while((len = reader.read(chs)) != -1) {
             writer.write(chs, 0, len);
         }

         writer.close();
         reader.close();
	 }
	if(pstmt!=null) pstmt.close();
	if(connection!=null) connection.close();
	}
 

 public static void main(String[] args) throws Exception {
	//update();
	 select();
 }

}