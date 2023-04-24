using Marqeta.Core.Sdk.Tests.MarqetaClientTests.Helpers;
using Xunit;

namespace Marqeta.Core.Sdk.Tests.MarqetaClientTests
{
    public class ProgramFundingControlTests : BaseTests
    {
        [Fact]
        public async void FundingsourcesProgramPostAsync()
        {
            await ProgramFundingHelper.CreateProgramFundingSource();
        }
    }
}