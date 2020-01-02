using NeuRos.Domain.Context;
using NeuRos.Domain.Entities;
using NeuRos.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace NeuRos.Domain.Data_Manager
{
    public class NmsRosDataManager : IDataRepository<NmsRos>
    {
        public readonly NeuRosDbContext _neuRosDbContext;
        public NmsRosDataManager(NeuRosDbContext neuRosDbContext)
        {
            _neuRosDbContext = neuRosDbContext;

        }
        public void Add(NmsRos entity)
        {
            throw new NotImplementedException();
        }

        public void Add(List<NmsRos> entities)
        {
            throw new NotImplementedException();
        }

        public void Delete(NmsRos entity)
        {
            throw new NotImplementedException();
        }

        public NmsRos Get(DateTime date)
        {
            throw new NotImplementedException();
        }

        public NmsRos Get(string id, int number)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<NmsRos> GetAll(DateTime date)
        {
            var RosDetails = _neuRosDbContext.NmsRoster.Where(e => e.Date == date);
            return RosDetails;
        }

        public IEnumerable<NmsRos> GetAll(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<NmsRos> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(int id, NmsRos entity)
        {
            throw new NotImplementedException();
        }

        public void UpdateAttendance(DateTime date, int Id)
        {
            NmsRos AttendanceUpdate = _neuRosDbContext.NmsRoster.FirstOrDefault(e => e.MemberId == Id && e.Date == date);
            AttendanceUpdate.Attendance = "Leave";
            _neuRosDbContext.SaveChanges();
        }
    }
}
