﻿using static EventManager;

public class CandSManager : AbstractSceneManager {
    
    public override void StartLearningPhase() {
        //ObjectPooler.SharedInstance.ActivateObject("VA_Male", Positions.AsideLeft);
        //EventManager.TriggerEvent(Triggers.VAIntroduce);
        TriggerEvent(Triggers.LearningPhaseStart);
    }
}

