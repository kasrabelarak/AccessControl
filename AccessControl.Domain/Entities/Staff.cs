using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessControl.Domain.Entities
{
    public  class Staff
    {
        public int Id { get; set; }
        public int Staff_Code { get; set; }
        public int Center_Code { get; set; }
        public int? Unit_Code { get; set; }
        public int? Ccode { get; set; }
        public string? Staff_Lname { get; set; }
        public string? Staff_Fname { get; set; }
        public string? Staff_Sex { get; set; }
        public string? Staff_Flname { get; set; }
        public int? Emp_Type_Code { get; set; }
        public int? Etccode { get; set; }
        public string? Staff_Work { get; set; }
        public string? Staff_Degree { get; set; }
        public byte[]? Staff_Pic { get; set; }
        public byte[]?  Staff_Sig { get; set; }
        public int? Staff_Room { get; set; }
        public int? Staff_RoomCcode { get; set; }
        public string? Staff_CardNumber { get; set; }
        public int? Card_Id { get; set; }
        public int? Shift_Code { get; set; }
        public int? ShCcode { get; set; }
        public int? ExWork_Code { get; set; }
        public int? ExWccode { get; set; }
        public string? Staff_Comment { get; set; }
        public string? Voice { get; set; }
        public int? Deferment { get; set; }
        public byte Proc_Completed { get; set; }
        public byte Sent { get; set; }
        public string? WorkCode { get; set; }
        public string? DriverLicense_Type { get; set; }
        public string? DriverLicense_Num { get; set; }
        public string? DriverLicense_Place { get; set; }
        public string? User_Name { get; set; }
        public string? National_Code { get; set; }
        public DateTime? BirthDate { get; set; }
        public string? BirthPlace { get; set; }
        public string? BirthCertificatePlace { get; set; }
        public string? Phone { get; set; }
        public string? CellPhone { get; set; }
        public string? Certificate { get; set; }
        public string? Home_Address { get; set; }
        public string? BirthCertificateNumber { get; set; }
        public string?  FloorName { get; set; }
        public string? InternalPhone1 { get; set; }
        public string? InternalPhone2 { get; set; }
        public string? InternalPhone3 { get; set; }
        public int AllegianceId { get; set; }
        public int MilitaryId { get; set; }
        public int ReligionId { get; set; }
        public string? PostalCode { get; set; }
        public bool? IsNative { get; set; }
        public DateTime? EmploymentDate { get; set; }
        public short? ReshtehStatus { get; set; }
        public short? MarriedStatus { get; set; }
        public string? Email { get; set; }
        public int? MilitaryTypeId { get; set; }
        public int? CardNo { get; set; }
        public bool? Retired { get; set; }
        public bool? Pony { get; set; }
        public int? JobsId { get; set; }
        public string? CompanyName { get; set; }
        public DateTime? EndDate { get; set; }
        public bool? Selected { get; set; }
        public bool? Printed { get; set; }
        public bool? CheckPrint { get; set; }
        public DateTime? PrintDate { get; set; }
        public int? ElecNum { get; set; }
        public bool? Forbid { get; set; }
        public int? DebtorId { get; set; }
        public DateTime? TasvieDate { get; set; }

        [NotMapped]
        public string? FullName { get; set; }
        public int? PrintCard { get; set; }
        public DateTime? RegCardDate { get; set; }
        [NotMapped]
        public string? WebId { get; set; }
        public bool? ShowInInternet { get; set; }
        public Guid StaffGuid { get; set; }
        public int? BloodType { get; set; }
        public string? LatinFirstName { get; set; }
        public string? LatinLastName { get; set; }
        public byte? CardStatus { get; set; }
        public bool? Replica { get; set; }
        public int? RoleId { get; set; }
    }
}
