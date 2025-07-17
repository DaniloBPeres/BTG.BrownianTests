using BTG.BrownianTests.Core.Models;

namespace BTG.BrownianTests.Core.Interface
{
    public interface IBrownianMotionService
    {
        BrownianResult Generate(BrownianParameters parameters);
    }
}
