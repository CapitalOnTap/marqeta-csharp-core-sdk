using Marqeta.Core.Sdk.Tests.Helpers;
using Xunit;

namespace Marqeta.Core.Sdk.Tests
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