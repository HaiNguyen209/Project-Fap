
# Project
# Simulate-FAP
Các chức năng chính của dự án: 
+ Login - Logout.
+ Có trang home/thông báo.
+ Trang chủ.
+ GV:(Nguồn: trang của thầy.)
  + Hiển thị danh sách thông tin điểm danh( attendend, absent.)
  + Điểm danh : Eidt-> sửa điểm danh. Save -> lưu lại.
  + Quản lý điểm (chưa rõ).  
  + View lịch dậy: Hiện lịch dậy: Hiển thị các môn dậy + phòng dậy + thời gian. (đọc data trong Db ra)
+ HS (Nếu có):
  + User profile.
  + Update profile.
  + view lịch học
  
 # Entity
Role(id, name)

Account ( ID, username, password, role_id )

Attendance(Id, Name, rollNumber, (image), status). - cho một lớp.

Schedule(id, accountId, subject_code, subject_name, slotId, room ). 

Slot(id, datetime)

Student(Id, Name, birthdate, gender, rollnumber, address, phone, email, image)
 # ERD 
 ![ERD-project-fap drawio](https://user-images.githubusercontent.com/79252420/177386511-b5832271-c191-4688-bea1-fd6d0477dd60.png)

