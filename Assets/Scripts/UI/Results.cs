using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Results : MonoBehaviour
{
    public static Results Instance;

    private void Awake()
    {
        Instance = this;
    }

    public List<TMPro.TextMeshProUGUI> attributeTotals;
    public List<TMPro.TextMeshProUGUI> resultText;
    public TMPro.TextMeshProUGUI rewardText;

    public TMPro.TextMeshProUGUI requestText;

    public void SetRequestText(string text)
    {
        requestText.text = $"\"{text}\"";
    }

    public void SetAttributeTotals(Dictionary<Attribute, int> attributes)
    {
        attributeTotals[0].text = $"Beauty {(attributes.ContainsKey(Attribute.Beauty) ? attributes[Attribute.Beauty] : 0)}";
        attributeTotals[1].text = $"Grace {(attributes.ContainsKey(Attribute.Grace) ? attributes[Attribute.Grace] : 0)}";
        attributeTotals[2].text = $"Power {(attributes.ContainsKey(Attribute.Power) ? attributes[Attribute.Power] : 0)}";
        attributeTotals[3].text = $"Smarts {(attributes.ContainsKey(Attribute.Smarts) ? attributes[Attribute.Smarts] : 0)}";
        attributeTotals[4].text = $"Trauma {(attributes.ContainsKey(Attribute.Trauma) ? attributes[Attribute.Trauma] : 0)}";

        if (attributes.ContainsKey(Attribute.Beauty))
        {
            SetResultText(0, attributes[Attribute.Beauty], BeautyStrings);
        }
        if (attributes.ContainsKey(Attribute.Grace))
        {
            SetResultText(1, attributes[Attribute.Grace], GraceStrings);
        }
        if (attributes.ContainsKey(Attribute.Power))
        {
            SetResultText(2, attributes[Attribute.Power], PowerStrings);
        }
        if (attributes.ContainsKey(Attribute.Smarts))
        {
            SetResultText(3, attributes[Attribute.Smarts], SmartsStrings);
        }
    }

    public void SetRewardText(int reward)
    {
        if (reward > 0)
        {
            rewardText.text = $"Collect Reward ({reward.ToString()} Shillings)";
        } else if (reward < 0)
        {
            rewardText.text = $"Failed ({reward.ToString()} Shillings)";
        } else
        {
            rewardText.text = $"Oh well, next creation.";
        }
        
    }

    public void SetResultText(int textIndex, int value, List<string> stringList)
    {
        if (value >= 80)
        {
            resultText[textIndex].text = stringList[4];
        }
        else if (value >= 70)
        {
            resultText[textIndex].text = stringList[3];
        }
        else if (value >= 50)
        {
            resultText[textIndex].text = stringList[2];
        }
        else if (value >= 40)
        {
            resultText[textIndex].text = stringList[1];
        }
        else
        {
            resultText[textIndex].text = stringList[0];
        }
    }

    public List<string> BeautyStrings = new List<string>()
    {
        "Hideously Ugly",
        "Ugly",
        "An Average Joe",
        "Pretty",
        "Very beautiful",
    };

    public List<string> GraceStrings = new List<string>()
    {
        "Disgustingly flat flooted",
        "Not going to win any tap dancing competitions",
        "Moderately lightfooted",
        "Nimble",
        "Gazelle-Like",
    };

    public List<string> PowerStrings = new List<string>()
    {
        "As weak as bad tea",
        "Unable to open a tough can",
        "Able to do a push-up",
        "Rather strong",
        "Herucles' Role model",
    };

    public List<string> SmartsStrings = new List<string>()
    {
        "Very very very very stupid",
        "A little thick",
        "Smart 'ish'",
        "Smarter than you",
        "A Genius",
    };

    public void ClickedCollect()
    {
        GameController.instance.ChangeState<RequestCompleteState>();
    }


}
