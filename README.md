<<<<<<< HEAD
# Project
=======
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
>>>>>>> c2cd1c4e807437a34add1d06f1460c02e82ac1f7
