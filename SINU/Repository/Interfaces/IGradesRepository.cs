using System.Collections.Generic;
using SINU.Model;

namespace SINU.Repository
{
    public interface IGradesRepository
    {
        public GradeInfo GetGradeById(int id);
        public List<GradeInfo> GetAll();
        public GradeInfo Create(GradeInfo gradeInfo);
    }
}

