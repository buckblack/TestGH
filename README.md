# TestGH
```c#
# GUI

  void btn_AddEmployee()  => BUS_ql.GetInstance().Them_nhan_vien(tbName, tbEmail,tbPassword,tbAddress,tbnumber);  

# BUS

 public void Them_nhan_vien(string name, string email, string password, string diachi, int dienthoai) {
    // Validate data
    if(!ValidateTelephoneNumber(dienthoai) || !Validate(email)) return;
    // replace space symbol
    name = name.Trim()
    diachi = diachi.Trim() 
    // call DTO
    NhanVien nv = new NhanVien(name,email,password,diachi,dienthoai);  
    // call DAL
    DAL_ql.GetInstance().Them_nhan_vien(nv); 
  }
  
# DAL

  public void Them_nhan_vien(NhanVien nv){
      MoKetNoi();    
      SqlCommand cm = new SqlCommand("insert into users(nv.name,nv.email,nv.password,nv.dia_chi,nv.dien_thoai,quyen) values(@name,@email,@password,@dia_chi,@dien_thoai,0)", cnn);
      cm.Parameters.AddWithValue("@name", nv.name);
      cm.Parameters.AddWithValue("@email", nv.email);
      cm.Parameters.AddWithValue("@password", BCrypt.Net.BCrypt.HashString(nv.password));
      cm.Parameters.AddWithValue("@dia_chi", nv.diachi);
      cm.Parameters.AddWithValue("@dien_thoai", nv.dienthoai);
      cm.ExecuteNonQuery();    
      DongKetNoi();
  }
