package org.student.service;

import java.sql.SQLException;
import java.util.List;

import org.student.dao.StudentDao;
import org.student.entity.Student;

public class StudentService {
	StudentDao studentDao=new StudentDao();
	
	public Student queryStudentBySno(int sno) throws ClassNotFoundException, SQLException {
		return studentDao.queryStudentBySno(sno);
	}
	public List<Student> queryStudentBySno() throws ClassNotFoundException, SQLException {
		return studentDao.queryAllstudent();
	}
	
	
	public boolean deleteStudentBysno(int sno) throws SQLException, ClassNotFoundException
	{
		if(studentDao.isExist(sno)) {
		return	studentDao.deleteStudentBySno(sno);
			
		}return false;
	}
	public boolean updateStudentBysbo(int sno,Student student) throws SQLException, ClassNotFoundException
	{
		if(studentDao.isExist(sno)) {
		return	studentDao.updateStudentBySno(sno,student);
			
		}return false;
	}
	
	
public boolean addStudent(Student student) throws ClassNotFoundException, SQLException
{
	if(studentDao.isExist(student.getSno()))
	{
		System.out.println("此人已存在");
	return false;
		 
	}else {
		
		studentDao.addStudent(student);
		 return true;
	}
}
}
