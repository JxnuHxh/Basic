package ji.jdbc;



import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;



public  class JDBCDemo {
	private static final String URL="jdbc:mysql://localhost:3306/store_08";
	private static final String username="root";
	private  static final String pwd="617662163";
 public static void update() throws Exception
 {
	 Class.forName("com.mysql.jdbc.Driver");
	Connection con= (Connection) DriverManager.getConnection(URL, username, pwd);
	 Statement stmt=con.createStatement();
	 String sql="insert into category value('99','��������')";
	int count= stmt.executeUpdate(sql); //������ɾ���˼�������
	if(count>0)
	{
		System.out.println("�����ɹ�");
	}
	if(con!=null)
	{
		con.close();
		stmt.close();
	}
 }
 public static void sel() throws  Exception
 {
	 ResultSet rs=  null;
	 Connection con=null;
	 Statement stmt=null;
	 Class.forName("com.mysql.jdbc.Driver");
con= (Connection) DriverManager.getConnection(URL, username, pwd);//ͨ��Connection����
		 stmt=con.createStatement();
		 String sql="select* from product";
		rs= stmt.executeQuery(sql); //������ɾ���˼������� 
		while(rs.next())
		{
			 int id=rs.getInt(1);//Ҳ����д1 ��ʾ��һ��
			String name=rs.getString("pname");
			System.out.println(id+"----"+name);
		}
		if(con!=null)
		{
			
			stmt.close();
			con.close();
			rs.close();
		}
	 
 }
 
public static void main(String[] args) throws Exception {
	
	//update();
	sel();
}
}
