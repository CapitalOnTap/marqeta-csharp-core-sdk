using System.Threading.Tasks;
using Marqeta.Core.Sdk.Tests.MarqetaClientTests.Helpers;
using Xunit;

namespace Marqeta.Core.Sdk.Tests.MarqetaClientTests
{
    public class ProgramFundingControlTests : BaseTests
    {
        [Fact]
        public async Task FundingsourcesProgramPostAsync()
        {
            await ProgramFundingHelper.CreateProgramFundingSource();
        }
    }
}