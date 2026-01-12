using Vintagestory.API.Client;
using Vintagestory.API.Common;
using Vintagestory.API.Config;
using Vintagestory.API.Server;
using conquestgeology.src.Blocks;
using conquestgeology.src.Blocks.Behaviors;

namespace conquestgeology.src
{
    public class conquestgeologyModSystem : ModSystem
    {
        // Called on server and client
        // Useful for registering block/entity classes on both sides
        public override void Start(ICoreAPI api)
        {
            RegisterBlockBehaviors(api);
            RegisterBlocks(api);
        }

        private void RegisterBlockBehaviors(ICoreAPI api)
        {
            api.RegisterBlockBehaviorClass("ModCorrectedSlab", typeof(ModCorrectedSlabBlockBehavior));
            api.RegisterBlockBehaviorClass("ModCorrectedHorizontalOrientableBehavior", typeof(ModCorrectedHorizontalOrientableBlockBehavior));


        }

        private void RegisterBlocks(ICoreAPI api)
        {
            api.RegisterBlockClass("BlockLayeredModCorrected", typeof(BlockLayeredModCorrected));
        }

    }
}
