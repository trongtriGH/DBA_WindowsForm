# WinFormsProject

Sử dụng Windows Form Application C# <br />
Nhớ install Oracle.ManagedDataAccess.Core bằng cách chuột phải vô solution rồi Manage NuGet Packages <br />
Mở View - Server Explorer tạo kết nối với Oracle, server name có cú pháp Hostname:Port/SID, nhớ refresh kết nối khi thoát ra vào lại <br />
Đổi cái connectionString cho phù hợp với database, ở đây có tạo user DBA_TEST và grant được quyền DBA <br />

Hiện tại có thể bị lỗi khi chạy nhiều lần, cần termiante: Ctrl + ` -> taskkill /F /IM WinFormsProject.exe
