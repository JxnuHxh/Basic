package org.student.servlet;

import java.io.IOException;
import java.sql.SQLException;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import org.student.service.StudentService;


@WebServlet("/DeleteStudentServlet")
public class DeleteStudentServlet extends HttpServlet {
	
	
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
               request.setCharacterEncoding("utf-8");
               int no=Integer.parseInt(request.getParameter("sno"));
               StudentService service=new StudentService();
               boolean result;
               response.setContentType("text/html;charset=utf-8");
       		response.setCharacterEncoding("utf-8");
		
				try {
					result = service.deleteStudentBysno(no);
					 if(result) {
		            	   response.getWriter().println("É¾³ý³É¹¦");
		               }else{
		            	   response.getWriter().println("É¾³ýÊ§°Ü");
		               }
				} catch (ClassNotFoundException e) {
					// TODO Auto-generated catch block
					e.printStackTrace();
				} catch (SQLException e) {
					// TODO Auto-generated catch block
					e.printStackTrace();
				}
			
               
	}

	
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
	
		doGet(request, response);
	}

}
