// 

#include "World/SOpenWorldGameMode.h"





ASOpenWorldGameMode::ASOpenWorldGameMode()
{
	/* Open world content is free-for-all */
	bAllowFriendlyFireDamage = true;
}


bool ASOpenWorldGameMode::CanSpectate_Implementation(APlayerController* Viewer, APlayerState* ViewTarget)
{
	return false;
}
