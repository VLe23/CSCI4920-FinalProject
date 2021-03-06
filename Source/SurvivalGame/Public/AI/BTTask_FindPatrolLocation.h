// 

#pragma once

#include "CoreMinimal.h"
#include "BehaviorTree/Tasks/BTTask_BlackboardBase.h"
#include "BTTask_FindPatrolLocation.generated.h"

/**
* Blackboard Task - Finds a position to a nearby waypoint
*/
UCLASS()
class SURVIVALGAME_API UBTTask_FindPatrolLocation : public UBTTask_BlackboardBase
{
	GENERATED_BODY()	

	virtual EBTNodeResult::Type ExecuteTask(UBehaviorTreeComponent& OwnerComp, uint8* NodeMemory) override;

};
