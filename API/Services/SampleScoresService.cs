using System.Collections.Generic;
using System.Threading.Tasks;
using API.Interfaces;
using API.Models;

namespace API.Services
{
    public class SampleScoresService : ISampleScoresService
    {
        public List<SampleScore> FormSampleScores(SampleScoresRequest request)
        {
            var sampleScoreList = new List<SampleScore>();
            var startPageIndex = ((request.PageNumber -1) * request.PageSize) + 1;
            var endPageIndex = (request.PageNumber * request.PageSize) < request.SampleMaxCount ? 
                    (request.PageNumber * request.PageSize) : request.SampleMaxCount;

            for (int i = startPageIndex; i <= endPageIndex; i++)
            {
                var sampleScore = new SampleScore();
                sampleScore.SampleNumber = i;

                if (i % request.PatientScore == 0 && i % request.DoctorScore == 0) {
                    sampleScore.Score = "Both";
                    sampleScoreList.Add(sampleScore);
                    continue;
                }

                if (i % request.PatientScore == 0)
                {
                    sampleScore.Score = "Patient";
                    sampleScoreList.Add(sampleScore);
                    continue;
                }
                if (i % request.DoctorScore == 0) 
                {
                    sampleScore.Score = "Doctor";
                    sampleScoreList.Add(sampleScore);
                    continue;
                }

                sampleScore.Score = "None";
                sampleScoreList.Add(sampleScore);
            }

            return sampleScoreList;
        }
    }
}