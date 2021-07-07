using System.Collections.Generic;
using System.Threading.Tasks;
using API.Models;

namespace API.Interfaces
{
    public interface ISampleScoresService
    {
        List<SampleScore> FormSampleScores(SampleScoresRequest request);
    }
}