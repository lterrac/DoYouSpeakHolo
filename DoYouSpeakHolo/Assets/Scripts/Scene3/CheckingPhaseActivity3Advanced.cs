﻿using UnityEngine;

class CheckingPhaseActivity3Advanced : CheckingPhaseActivity3 {

    protected override void CheckingPhase() {
        possessivesManager = (PossessivesManager)sceneManager;

        //Create the baskets and attach to them the script
        CreatePeopleAndBaskets();

        //Spawn Fruits in random order
        CreateAllObjectsAndDisplayInRandomOrder();
    }

    protected void CreateAllObjectsAndDisplayInRandomOrder() {
        //Shuffle the collection
        SceneObjects = AbstractSceneManager.Shuffle(SceneObjects);
        GameObject gameObj;
        //Define initial spawning position
        Vector3 startPosition = Positions.startPositionInlineFour;
        foreach (string obj in SceneObjects) {
            //Activate the object and attach to it the script for the task
            gameObj = possessivesManager.ActivateObject(obj, startPosition);
            SetFruitScripts(gameObj);
            startPosition += new Vector3(0.2f, 0, 0);
        }
    }
}