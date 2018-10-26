using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectJournal : MonoBehaviour {

    public int journalID;

    public Canvas GUI;

    private string journalText;

    GUI_Controller gui_controller;

	// Use this for initialization
	void Start () {
        gui_controller = GUI.GetComponent<GUI_Controller>();
        journalText = "Journal Closed";
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            switch (journalID)
            {
                case 1:
                    journalText = "While my posting on the doors does grow morose at times, I am ever grateful I am not put watching the halls below. " +
                                "For I saw them drag Ed’s corpse from here. It had been ravished beyond belief and he was hardly recognisable. " +
                                "He had been grabbed by one of the demon’s while on patrol and they kept going until they’d had their fill. " +
                                "Luckily William had seen them while on patrol and forced them back to their cage, but it was too late for Ed. " +
                                "As hard as it is here, I am glad I am not down there. I am glad I will not end up like Ed.";
                    break;
                case 2:
                    journalText = "This place is dank and depressing. We should never have returned here. Some things should just remain in the dark, never to be seen again. " +
                                  "Sleeping here is a nightmare. You can hear their screams from below, constant, echoing, terrifying. They never stop. " +
                                  "I feel like I will go mad just from the sound. I am lucky I do not have to go down there often, I can’t imagine how the others feel. " +
                                  "Walking the halls. Guarding our infernal denizens. I should find a way out of here soon. " +
                                  "God-given right or not, this place is death and only bad things can come of it.";
                    break;
                case 3:
                    journalText = "There are too many green boys here. Boys that would piss themselves were a demon to but scream at them. They’re not what we need here now. " +
                                  "But all the experienced ones are out in the field, hunting the fiends so they can be bought here. " +
                                  "But what good are they here if their guards are too piss weak to keep them here? I am but one man and despite my long history with these beasts, " +
                                  "I know that a man alone cannot halt a demon horde. I must make sure they are ready, and prepared for the oncoming storm. For there will be a storm. " +
                                  "I can guarantee it.";
                    break;
                case 4:
                    journalText = "We are the Greater Key.\r\nWe will never stop.\r\nWe will never cease.\r\nWe will never surrender.\r\nHark now you beasts.\r\n" +
                                  "You infernal demons.\r\nYou unholy scourge.\r\nYou fiendish horrors.\r\nWe will take you all.\r\nForced from our lands.\r\n" +
                                  "Chained by our hands.\r\nBurned by our brands.\r\nWe are the Greater Key.";
                    break;
                case 5:
                    journalText = "I don’t know which is more terrifying. Patrolling the cells of the fiends or being the last line of defence if they escape. " +
                                  "I have done both and still cannot decide. At least here I would have some warning before I die. For if they escape no-one is leaving here alive. " +
                                  "We can’t stop them and perhaps never will. They will just keep coming. And they will slaughter us all.";
                    break;
                case 6:
                    journalText = "How did I come to be in this place. I am not meant to be here. I was meant to fight and destroy demons, not to keep watch on them. I can feel them watching. " +
                                  "Leering. Their burning hatred leaking forth from their cells. They want me dead and they know they can do that. If I make but one mistake, I will end up like Ed. " +
                                  "Oh how I wish I were home. In the green fields up north. If I had known, I would never have come here. I would have stayed, not been so eager to leave. " +
                                  "I am sorry mother. I hope I will see you again.";
                    break;
                case 7:
                    journalText = "The work we do here is bloody but necessary. By exploring their physical form, we can find more efficient rituals to banish demon kind. " +
                                  "Progress is slow and interpreting the old texts is practically impossible. While they would be useful they are far too old and the writing has faded. " +
                                  "Thus we must resort to more barbaric measures. At least they are not human, but their screams are just as horrifying. " +
                                  "Only my faith in God has kept me strong and if it were not for my divine calling I would have left long ago. " +
                                  "But my work is important and I will continue until it is complete.";
                    break;
                case 8:
                    journalText = "These Greater Demons are much more of a challenge than those upstairs. Their wills are much more tolerant and bend more so than break. " +
                                  "Malphas is perhaps the worst of them. Even when enduring the harshest of pain he simply sits there and smiles. It is maddening. " +
                                  "I know not what to do and I think there is more to him than there seems. Perhaps we were wrong to bring him here, " +
                                  "he may be more than we can possibly hope to handle at this point. But orders from the divine are absolute and I will not falter. " +
                                  "He will break. And he will break soon.";
                    break;
                case 9:
                    journalText = "I am Malphas, Lord of Deception. These pathetic humans think they are so clever. But bringing us all into one place just makes it all the easier. " +
                                  "Their minds are already exposed and weak being around us all the time and I will need barely any time with them before I twist them to my will. " +
                                  "They will not contain me for long. The chaos Moloch and I sow will be glorious. I will escape, darkness will spread and humanity will perish once and for all.";
                    break;
            }

            gui_controller.journalOpen(journalText);
            transform.position = new Vector3(100, 0, 100);
        }
    }
}
