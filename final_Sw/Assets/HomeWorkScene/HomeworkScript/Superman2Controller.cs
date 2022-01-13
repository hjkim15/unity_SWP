using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Superman2Controller : MonoBehaviour
{
    public static Superman2Controller instance = null;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            if (instance != this)
                Destroy(this.gameObject);
        }
    }

    int count;
    public int code3Count;

    GameObject s2_0;
    GameObject s2_1;
    GameObject s2_2;
    GameObject s2_3;
    GameObject s2_4;
    GameObject s2_5;
    GameObject s2_6;
    GameObject s2_7;
    GameObject s2_8;

    GameObject explain2;
    GameObject particle;
    GameObject circle2;
    GameObject talk;
    GameObject Talk2;
    GameObject cam;

    float moveSpeed = 4.0f;

    bool isAlive = true;
    bool isAlive1 = false;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "s2_0" && Code2Generator.instance.array2[0] == 0 && count == 0)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(54.34f, -2.51f, 0);

            this.explain2.GetComponent<Text>().text = "<color=white>" + "#include <iostream>은 컴파일러 전처리기 지시자로 컴파일러로 하여금 화면 입출력을 위해 이 프로그램에 "
            + "iostream 라이브러리를 포함하도록 한다. C++ 라이브러리에는 C++ 프로그램 개발을 위해 미리 정의된 코드가 포함되어 있다. "
            + "iostream 같은 라이브러리는 C++에서 헤더 파일이라고 하는데, 보통 프로그램의 상단에 위치하기 때문이다." + "</color>";

            if (Code2Generator.instance.code2_0 != null)
            {
                Destroy(Code2Generator.instance.code2_0);
            }
            else
            {; }
            if (this.s2_0 != null)
            {
                Destroy(this.s2_0);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_1" && Code2Generator.instance.array2[0] == 1 && count == 0)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(54.34f, -2.51f, 0);

            this.explain2.GetComponent<Text>().text = "<color=white>" + "#include <iostream>은 컴파일러 전처리기 지시자로 컴파일러로 하여금 화면 입출력을 위해 이 프로그램에 "
            + "iostream 라이브러리를 포함하도록 한다. C++ 라이브러리에는 C++ 프로그램 개발을 위해 미리 정의된 코드가 포함되어 있다. "
            + "iostream 같은 라이브러리는 C++에서 헤더 파일이라고 하는데, 보통 프로그램의 상단에 위치하기 때문이다." + "</color>";

            if (Code2Generator.instance.code2_1 != null)
            {
                Destroy(Code2Generator.instance.code2_1);
            }
            else
            {; }
            if (this.s2_1 != null)
            {
                Destroy(this.s2_1);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_2" && Code2Generator.instance.array2[0] == 2 && count == 0)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(54.34f, -2.51f, 0);

            this.explain2.GetComponent<Text>().text = "<color=white>" + "#include <iostream>은 컴파일러 전처리기 지시자로 컴파일러로 하여금 화면 입출력을 위해 이 프로그램에 "
            + "iostream 라이브러리를 포함하도록 한다. C++ 라이브러리에는 C++ 프로그램 개발을 위해 미리 정의된 코드가 포함되어 있다. "
            + "iostream 같은 라이브러리는 C++에서 헤더 파일이라고 하는데, 보통 프로그램의 상단에 위치하기 때문이다." + "</color>";

            if (Code2Generator.instance.code2_2 != null)
            {
                Destroy(Code2Generator.instance.code2_2);
            }
            else
            {; }
            if (this.s2_2 != null)
            {
                Destroy(this.s2_2);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_3" && Code2Generator.instance.array2[0] == 3 && count == 0)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(54.34f, -2.51f, 0);

            this.explain2.GetComponent<Text>().text = "<color=white>" + "#include <iostream>은 컴파일러 전처리기 지시자로 컴파일러로 하여금 화면 입출력을 위해 이 프로그램에 "
            + "iostream 라이브러리를 포함하도록 한다. C++ 라이브러리에는 C++ 프로그램 개발을 위해 미리 정의된 코드가 포함되어 있다. "
            + "iostream 같은 라이브러리는 C++에서 헤더 파일이라고 하는데, 보통 프로그램의 상단에 위치하기 때문이다." + "</color>";

            if (Code2Generator.instance.code2_3 != null)
            {
                Destroy(Code2Generator.instance.code2_3);
            }
            else
            {; }
            if (this.s2_3 != null)
            {
                Destroy(this.s2_3);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_4" && Code2Generator.instance.array2[0] == 4 && count == 0)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(54.34f, -2.51f, 0);

            this.explain2.GetComponent<Text>().text = "<color=white>" + "#include <iostream>은 컴파일러 전처리기 지시자로 컴파일러로 하여금 화면 입출력을 위해 이 프로그램에 "
            + "iostream 라이브러리를 포함하도록 한다. C++ 라이브러리에는 C++ 프로그램 개발을 위해 미리 정의된 코드가 포함되어 있다. "
            + "iostream 같은 라이브러리는 C++에서 헤더 파일이라고 하는데, 보통 프로그램의 상단에 위치하기 때문이다." + "</color>";

            if (Code2Generator.instance.code2_4 != null)
            {
                Destroy(Code2Generator.instance.code2_4);
            }
            else
            {; }
            if (this.s2_4 != null)
            {
                Destroy(this.s2_4);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_5" && Code2Generator.instance.array2[0] == 5 && count == 0)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(54.34f, -2.51f, 0);

            this.explain2.GetComponent<Text>().text = "<color=white>" + "#include <iostream>은 컴파일러 전처리기 지시자로 컴파일러로 하여금 화면 입출력을 위해 이 프로그램에 "
            + "iostream 라이브러리를 포함하도록 한다. C++ 라이브러리에는 C++ 프로그램 개발을 위해 미리 정의된 코드가 포함되어 있다. "
            + "iostream 같은 라이브러리는 C++에서 헤더 파일이라고 하는데, 보통 프로그램의 상단에 위치하기 때문이다." + "</color>";

            if (Code2Generator.instance.code2_5 != null)
            {
                Destroy(Code2Generator.instance.code2_5);
            }
            else
            {; }
            if (this.s2_5 != null)
            {
                Destroy(this.s2_5);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_6" && Code2Generator.instance.array2[0] == 6 && count == 0)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(54.34f, -2.51f, 0);

            this.explain2.GetComponent<Text>().text = "<color=white>" + "#include <iostream>은 컴파일러 전처리기 지시자로 컴파일러로 하여금 화면 입출력을 위해 이 프로그램에 "
            + "iostream 라이브러리를 포함하도록 한다. C++ 라이브러리에는 C++ 프로그램 개발을 위해 미리 정의된 코드가 포함되어 있다. "
            + "iostream 같은 라이브러리는 C++에서 헤더 파일이라고 하는데, 보통 프로그램의 상단에 위치하기 때문이다." + "</color>";

            if (Code2Generator.instance.code2_6 != null)
            {
                Destroy(Code2Generator.instance.code2_6);
            }
            else
            {; }
            if (this.s2_6 != null)
            {
                Destroy(this.s2_6);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_7" && Code2Generator.instance.array2[0] == 7 && count == 0)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(54.34f, -2.51f, 0);

            this.explain2.GetComponent<Text>().text = "<color=white>" + "#include <iostream>은 컴파일러 전처리기 지시자로 컴파일러로 하여금 화면 입출력을 위해 이 프로그램에 "
            + "iostream 라이브러리를 포함하도록 한다. C++ 라이브러리에는 C++ 프로그램 개발을 위해 미리 정의된 코드가 포함되어 있다. "
            + "iostream 같은 라이브러리는 C++에서 헤더 파일이라고 하는데, 보통 프로그램의 상단에 위치하기 때문이다." + "</color>";

            if (Code2Generator.instance.code2_7 != null)
            {
                Destroy(Code2Generator.instance.code2_7);
            }
            else
            {; }
            if (this.s2_7 != null)
            {
                Destroy(this.s2_7);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_8" && Code2Generator.instance.array2[0] == 8 && count == 0)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(54.34f, -2.51f, 0);

            this.explain2.GetComponent<Text>().text = "<color=white>" + "#include <iostream>은 컴파일러 전처리기 지시자로 컴파일러로 하여금 화면 입출력을 위해 이 프로그램에 "
            + "iostream 라이브러리를 포함하도록 한다. C++ 라이브러리에는 C++ 프로그램 개발을 위해 미리 정의된 코드가 포함되어 있다. "
            + "iostream 같은 라이브러리는 C++에서 헤더 파일이라고 하는데, 보통 프로그램의 상단에 위치하기 때문이다." + "</color>";

            if (Code2Generator.instance.code2_8 != null)
            {
                Destroy(Code2Generator.instance.code2_8);
            }
            else
            {; }
            if (this.s2_8 != null)
            {
                Destroy(this.s2_8);
            }
            else
            {; }
            count++;
        }

        if (other.gameObject.tag == "s2_0" && Code2Generator.instance.array2[1] == 0 && count == 1)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(53.24f, -3.04f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "using namespace std;는 컴파일러에게 표준 네임스페이스를 사용한다고 알려 주는 것이다. "
            + "std는 표준(standard)의 줄임말이다. 네임스페이스란 큰 프로그램에서 이름으로 인한 혼란을 피하기 위해 정의된 것이다. "
            + "16번 줄의 cout과 endl이라는 이름은 표준 네임스페이스에서 iostream 라이브러리에 정의되어 있다. 컴파일러가 이들 이름을 찾도록 하기 위해서 using namespace std; "
            + "문장이 사용되어야 한다." + "</color>";

            if (Code2Generator.instance.code2_0 != null)
            {
                Destroy(Code2Generator.instance.code2_0);
            }
            else
            {; }
            if (this.s2_0 != null)
            {
                Destroy(this.s2_0);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_1" && Code2Generator.instance.array2[1] == 1 && count == 1)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(53.24f, -3.04f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "using namespace std;는 컴파일러에게 표준 네임스페이스를 사용한다고 알려 주는 것이다. "
            + "std는 표준(standard)의 줄임말이다. 네임스페이스란 큰 프로그램에서 이름으로 인한 혼란을 피하기 위해 정의된 것이다. "
            + "16번 줄의 cout과 endl이라는 이름은 표준 네임스페이스에서 iostream 라이브러리에 정의되어 있다. 컴파일러가 이들 이름을 찾도록 하기 위해서 using namespace std; "
            + "문장이 사용되어야 한다." + "</color>";

            if (Code2Generator.instance.code2_1 != null)
            {
                Destroy(Code2Generator.instance.code2_1);
            }
            else
            {; }
            if (this.s2_1 != null)
            {
                Destroy(this.s2_1);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_2" && Code2Generator.instance.array2[1] == 2 && count == 1)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(53.24f, -3.04f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "using namespace std;는 컴파일러에게 표준 네임스페이스를 사용한다고 알려 주는 것이다. "
            + "std는 표준(standard)의 줄임말이다. 네임스페이스란 큰 프로그램에서 이름으로 인한 혼란을 피하기 위해 정의된 것이다. "
            + "16번 줄의 cout과 endl이라는 이름은 표준 네임스페이스에서 iostream 라이브러리에 정의되어 있다. 컴파일러가 이들 이름을 찾도록 하기 위해서 using namespace std; "
            + "문장이 사용되어야 한다." + "</color>";

            if (Code2Generator.instance.code2_2 != null)
            {
                Destroy(Code2Generator.instance.code2_2);
            }
            else
            {; }
            if (this.s2_2 != null)
            {
                Destroy(this.s2_2);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_3" && Code2Generator.instance.array2[1] == 3 && count == 1)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(53.24f, -3.04f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "using namespace std;는 컴파일러에게 표준 네임스페이스를 사용한다고 알려 주는 것이다. "
            + "std는 표준(standard)의 줄임말이다. 네임스페이스란 큰 프로그램에서 이름으로 인한 혼란을 피하기 위해 정의된 것이다. "
            + "16번 줄의 cout과 endl이라는 이름은 표준 네임스페이스에서 iostream 라이브러리에 정의되어 있다. 컴파일러가 이들 이름을 찾도록 하기 위해서 using namespace std; "
            + "문장이 사용되어야 한다." + "</color>";

            if (Code2Generator.instance.code2_3 != null)
            {
                Destroy(Code2Generator.instance.code2_3);
            }
            else
            {; }
            if (this.s2_3 != null)
            {
                Destroy(this.s2_3);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_4" && Code2Generator.instance.array2[1] == 4 && count == 1)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(53.24f, -3.04f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "using namespace std;는 컴파일러에게 표준 네임스페이스를 사용한다고 알려 주는 것이다. "
            + "std는 표준(standard)의 줄임말이다. 네임스페이스란 큰 프로그램에서 이름으로 인한 혼란을 피하기 위해 정의된 것이다. "
            + "16번 줄의 cout과 endl이라는 이름은 표준 네임스페이스에서 iostream 라이브러리에 정의되어 있다. 컴파일러가 이들 이름을 찾도록 하기 위해서 using namespace std; "
            + "문장이 사용되어야 한다." + "</color>";

            if (Code2Generator.instance.code2_4 != null)
            {
                Destroy(Code2Generator.instance.code2_4);
            }
            else
            {; }
            if (this.s2_4 != null)
            {
                Destroy(this.s2_4);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_5" && Code2Generator.instance.array2[1] == 5 && count == 1)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(53.24f, -3.04f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "using namespace std;는 컴파일러에게 표준 네임스페이스를 사용한다고 알려 주는 것이다. "
            + "std는 표준(standard)의 줄임말이다. 네임스페이스란 큰 프로그램에서 이름으로 인한 혼란을 피하기 위해 정의된 것이다. "
            + "16번 줄의 cout과 endl이라는 이름은 표준 네임스페이스에서 iostream 라이브러리에 정의되어 있다. 컴파일러가 이들 이름을 찾도록 하기 위해서 using namespace std; "
            + "문장이 사용되어야 한다." + "</color>";

            if (Code2Generator.instance.code2_5 != null)
            {
                Destroy(Code2Generator.instance.code2_5);
            }
            else
            {; }
            if (this.s2_5 != null)
            {
                Destroy(this.s2_5);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_6" && Code2Generator.instance.array2[1] == 6 && count == 1)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(53.24f, -3.04f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "using namespace std;는 컴파일러에게 표준 네임스페이스를 사용한다고 알려 주는 것이다. "
            + "std는 표준(standard)의 줄임말이다. 네임스페이스란 큰 프로그램에서 이름으로 인한 혼란을 피하기 위해 정의된 것이다. "
            + "16번 줄의 cout과 endl이라는 이름은 표준 네임스페이스에서 iostream 라이브러리에 정의되어 있다. 컴파일러가 이들 이름을 찾도록 하기 위해서 using namespace std; "
            + "문장이 사용되어야 한다." + "</color>";

            if (Code2Generator.instance.code2_6 != null)
            {
                Destroy(Code2Generator.instance.code2_6);
            }
            else
            {; }
            if (this.s2_6 != null)
            {
                Destroy(this.s2_6);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_7" && Code2Generator.instance.array2[1] == 7 && count == 1)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(53.24f, -3.04f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "using namespace std;는 컴파일러에게 표준 네임스페이스를 사용한다고 알려 주는 것이다. "
            + "std는 표준(standard)의 줄임말이다. 네임스페이스란 큰 프로그램에서 이름으로 인한 혼란을 피하기 위해 정의된 것이다. "
            + "16번 줄의 cout과 endl이라는 이름은 표준 네임스페이스에서 iostream 라이브러리에 정의되어 있다. 컴파일러가 이들 이름을 찾도록 하기 위해서 using namespace std; "
            + "문장이 사용되어야 한다." + "</color>";

            if (Code2Generator.instance.code2_7 != null)
            {
                Destroy(Code2Generator.instance.code2_7);
            }
            else
            {; }
            if (this.s2_7 != null)
            {
                Destroy(this.s2_7);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_8" && Code2Generator.instance.array2[1] == 8 && count == 1)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(53.24f, -3.04f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "using namespace std;는 컴파일러에게 표준 네임스페이스를 사용한다고 알려 주는 것이다. "
            + "std는 표준(standard)의 줄임말이다. 네임스페이스란 큰 프로그램에서 이름으로 인한 혼란을 피하기 위해 정의된 것이다. "
            + "16번 줄의 cout과 endl이라는 이름은 표준 네임스페이스에서 iostream 라이브러리에 정의되어 있다. 컴파일러가 이들 이름을 찾도록 하기 위해서 using namespace std; "
            + "문장이 사용되어야 한다." + "</color>";

            if (Code2Generator.instance.code2_8 != null)
            {
                Destroy(Code2Generator.instance.code2_8);
            }
            else
            {; }
            if (this.s2_8 != null)
            {
                Destroy(this.s2_8);
            }
            else
            {; }
            count++;
        }

        if (other.gameObject.tag == "s2_0" && Code2Generator.instance.array2[2] == 0 && count == 2)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(54.1f, -3.53f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "모든 C++ 프로그램은 main 함수로부터 실행되며, 하나의 함수는 문장으로 구성된다. "
            + "4~16번 줄에 작성된 main 함수에는 2개의 문장이 있다. 그러한 문장들은 블록안에 작성되는데, 문장은 {(5번 줄)로 시작되며} (16번 줄)로 끝이 난다. "
            + "C++에서 모든 문장은 문 종결자인 ;(세미콜론)으로 끝내야 한다." + "</color>";

            if (Code2Generator.instance.code2_0 != null)
            {
                Destroy(Code2Generator.instance.code2_0);
            }
            else
            {; }
            if (this.s2_0 != null)
            {
                Destroy(this.s2_0);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_1" && Code2Generator.instance.array2[2] == 1 && count == 2)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(54.1f, -3.53f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "모든 C++ 프로그램은 main 함수로부터 실행되며, 하나의 함수는 문장으로 구성된다. "
            + "4~16번 줄에 작성된 main 함수에는 2개의 문장이 있다. 그러한 문장들은 블록안에 작성되는데, 문장은 {(5번 줄)로 시작되며} (16번 줄)로 끝이 난다. "
            + "C++에서 모든 문장은 문 종결자인 ;(세미콜론)으로 끝내야 한다." + "</color>";

            if (Code2Generator.instance.code2_1 != null)
            {
                Destroy(Code2Generator.instance.code2_1);
            }
            else
            {; }
            if (this.s2_1 != null)
            {
                Destroy(this.s2_1);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_2" && Code2Generator.instance.array2[2] == 2 && count == 2)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(54.1f, -3.53f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "모든 C++ 프로그램은 main 함수로부터 실행되며, 하나의 함수는 문장으로 구성된다. "
            + "4~16번 줄에 작성된 main 함수에는 2개의 문장이 있다. 그러한 문장들은 블록안에 작성되는데, 문장은 {(5번 줄)로 시작되며} (16번 줄)로 끝이 난다. "
            + "C++에서 모든 문장은 문 종결자인 ;(세미콜론)으로 끝내야 한다." + "</color>";

            if (Code2Generator.instance.code2_2 != null)
            {
                Destroy(Code2Generator.instance.code2_2);
            }
            else
            {; }
            if (this.s2_2 != null)
            {
                Destroy(this.s2_2);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_3" && Code2Generator.instance.array2[2] == 3 && count == 2)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(54.1f, -3.53f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "모든 C++ 프로그램은 main 함수로부터 실행되며, 하나의 함수는 문장으로 구성된다. "
            + "4~16번 줄에 작성된 main 함수에는 2개의 문장이 있다. 그러한 문장들은 블록안에 작성되는데, 문장은 {(5번 줄)로 시작되며} (16번 줄)로 끝이 난다. "
            + "C++에서 모든 문장은 문 종결자인 ;(세미콜론)으로 끝내야 한다." + "</color>";

            if (Code2Generator.instance.code2_3 != null)
            {
                Destroy(Code2Generator.instance.code2_3);
            }
            else
            {; }
            if (this.s2_3 != null)
            {
                Destroy(this.s2_3);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_4" && Code2Generator.instance.array2[2] == 4 && count == 2)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(54.1f, -3.53f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "모든 C++ 프로그램은 main 함수로부터 실행되며, 하나의 함수는 문장으로 구성된다. "
            + "4~16번 줄에 작성된 main 함수에는 2개의 문장이 있다. 그러한 문장들은 블록안에 작성되는데, 문장은 {(5번 줄)로 시작되며} (16번 줄)로 끝이 난다. "
            + "C++에서 모든 문장은 문 종결자인 ;(세미콜론)으로 끝내야 한다." + "</color>";

            if (Code2Generator.instance.code2_4 != null)
            {
                Destroy(Code2Generator.instance.code2_4);
            }
            else
            {; }
            if (this.s2_4 != null)
            {
                Destroy(this.s2_4);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_5" && Code2Generator.instance.array2[2] == 5 && count == 2)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(54.1f, -3.53f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "모든 C++ 프로그램은 main 함수로부터 실행되며, 하나의 함수는 문장으로 구성된다. "
            + "4~16번 줄에 작성된 main 함수에는 2개의 문장이 있다. 그러한 문장들은 블록안에 작성되는데, 문장은 {(5번 줄)로 시작되며} (16번 줄)로 끝이 난다. "
            + "C++에서 모든 문장은 문 종결자인 ;(세미콜론)으로 끝내야 한다." + "</color>";

            if (Code2Generator.instance.code2_5 != null)
            {
                Destroy(Code2Generator.instance.code2_5);
            }
            else
            {; }
            if (this.s2_5 != null)
            {
                Destroy(this.s2_5);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_6" && Code2Generator.instance.array2[2] == 6 && count == 2)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(54.1f, -3.53f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "모든 C++ 프로그램은 main 함수로부터 실행되며, 하나의 함수는 문장으로 구성된다. "
            + "4~16번 줄에 작성된 main 함수에는 2개의 문장이 있다. 그러한 문장들은 블록안에 작성되는데, 문장은 {(5번 줄)로 시작되며} (16번 줄)로 끝이 난다. "
            + "C++에서 모든 문장은 문 종결자인 ;(세미콜론)으로 끝내야 한다." + "</color>";

            if (Code2Generator.instance.code2_6 != null)
            {
                Destroy(Code2Generator.instance.code2_6);
            }
            else
            {; }
            if (this.s2_6 != null)
            {
                Destroy(this.s2_6);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_7" && Code2Generator.instance.array2[2] == 7 && count == 2)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(54.1f, -3.53f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "모든 C++ 프로그램은 main 함수로부터 실행되며, 하나의 함수는 문장으로 구성된다. "
            + "4~16번 줄에 작성된 main 함수에는 2개의 문장이 있다. 그러한 문장들은 블록안에 작성되는데, 문장은 {(5번 줄)로 시작되며} (16번 줄)로 끝이 난다. "
            + "C++에서 모든 문장은 문 종결자인 ;(세미콜론)으로 끝내야 한다." + "</color>";

            if (Code2Generator.instance.code2_7 != null)
            {
                Destroy(Code2Generator.instance.code2_7);
            }
            else
            {; }
            if (this.s2_7 != null)
            {
                Destroy(this.s2_7);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_8" && Code2Generator.instance.array2[2] == 8 && count == 2)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(54.1f, -3.53f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "모든 C++ 프로그램은 main 함수로부터 실행되며, 하나의 함수는 문장으로 구성된다. "
            + "4~16번 줄에 작성된 main 함수에는 2개의 문장이 있다. 그러한 문장들은 블록안에 작성되는데, 문장은 {(5번 줄)로 시작되며} (16번 줄)로 끝이 난다. "
            + "C++에서 모든 문장은 문 종결자인 ;(세미콜론)으로 끝내야 한다." + "</color>";

            if (Code2Generator.instance.code2_8 != null)
            {
                Destroy(Code2Generator.instance.code2_8);
            }
            else
            {; }
            if (this.s2_8 != null)
            {
                Destroy(this.s2_8);
            }
            else
            {; }
            count++;
        }

        if (other.gameObject.tag == "s2_0" && Code2Generator.instance.array2[3] == 0 && count == 3)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(53.88f, -3.85f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "radius와 같은 변수는 메모리에 기억 장소를 둔다. "
                + "모든 변수는 이름, 유형, 크기, 값이 있다. 6번 줄은 radius에 double(실수) 형의 값을 기억하도록 한 것이며, radius 변수의 값은 값을 할당하기 전까지는 결정되지 않는다."
                + "</color>";

            if (Code2Generator.instance.code2_0 != null)
            {
                Destroy(Code2Generator.instance.code2_0);
            }
            else
            {; }
            if (this.s2_0 != null)
            {
                Destroy(this.s2_0);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_1" && Code2Generator.instance.array2[3] == 1 && count == 3)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(53.88f, -3.85f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "radius와 같은 변수는 메모리에 기억 장소를 둔다. "
                + "모든 변수는 이름, 유형, 크기, 값이 있다. 6번 줄은 radius에 double(실수) 형의 값을 기억하도록 한 것이며, radius 변수의 값은 값을 할당하기 전까지는 결정되지 않는다."
                + "</color>";

            if (Code2Generator.instance.code2_1 != null)
            {
                Destroy(Code2Generator.instance.code2_1);
            }
            else
            {; }
            if (this.s2_1 != null)
            {
                Destroy(this.s2_1);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_2" && Code2Generator.instance.array2[3] == 2 && count == 3)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(53.88f, -3.85f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "radius와 같은 변수는 메모리에 기억 장소를 둔다. "
                + "모든 변수는 이름, 유형, 크기, 값이 있다. 6번 줄은 radius에 double(실수) 형의 값을 기억하도록 한 것이며, radius 변수의 값은 값을 할당하기 전까지는 결정되지 않는다."
                + "</color>";

            if (Code2Generator.instance.code2_2 != null)
            {
                Destroy(Code2Generator.instance.code2_2);
            }
            else
            {; }
            if (this.s2_2 != null)
            {
                Destroy(this.s2_2);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_3" && Code2Generator.instance.array2[3] == 3 && count == 3)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(53.88f, -3.85f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "radius와 같은 변수는 메모리에 기억 장소를 둔다. "
                + "모든 변수는 이름, 유형, 크기, 값이 있다. 6번 줄은 radius에 double(실수) 형의 값을 기억하도록 한 것이며, radius 변수의 값은 값을 할당하기 전까지는 결정되지 않는다."
                + "</color>";

            if (Code2Generator.instance.code2_3 != null)
            {
                Destroy(Code2Generator.instance.code2_3);
            }
            else
            {; }
            if (this.s2_3 != null)
            {
                Destroy(this.s2_3);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_4" && Code2Generator.instance.array2[3] == 4 && count == 3)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(53.88f, -3.85f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "radius와 같은 변수는 메모리에 기억 장소를 둔다. "
                + "모든 변수는 이름, 유형, 크기, 값이 있다. 6번 줄은 radius에 double(실수) 형의 값을 기억하도록 한 것이며, radius 변수의 값은 값을 할당하기 전까지는 결정되지 않는다."
                + "</color>";

            if (Code2Generator.instance.code2_4 != null)
            {
                Destroy(Code2Generator.instance.code2_4);
            }
            else
            {; }
            if (this.s2_4 != null)
            {
                Destroy(this.s2_4);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_5" && Code2Generator.instance.array2[3] == 5 && count == 3)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(53.88f, -3.85f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "radius와 같은 변수는 메모리에 기억 장소를 둔다. "
                + "모든 변수는 이름, 유형, 크기, 값이 있다. 6번 줄은 radius에 double(실수) 형의 값을 기억하도록 한 것이며, radius 변수의 값은 값을 할당하기 전까지는 결정되지 않는다."
                + "</color>";

            if (Code2Generator.instance.code2_5 != null)
            {
                Destroy(Code2Generator.instance.code2_5);
            }
            else
            {; }
            if (this.s2_5 != null)
            {
                Destroy(this.s2_5);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_6" && Code2Generator.instance.array2[3] == 6 && count == 3)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(53.88f, -3.85f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "radius와 같은 변수는 메모리에 기억 장소를 둔다. "
                + "모든 변수는 이름, 유형, 크기, 값이 있다. 6번 줄은 radius에 double(실수) 형의 값을 기억하도록 한 것이며, radius 변수의 값은 값을 할당하기 전까지는 결정되지 않는다."
                + "</color>";

            if (Code2Generator.instance.code2_6 != null)
            {
                Destroy(Code2Generator.instance.code2_6);
            }
            else
            {; }
            if (this.s2_6 != null)
            {
                Destroy(this.s2_6);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_7" && Code2Generator.instance.array2[3] == 7 && count == 3)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(53.88f, -3.85f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "radius와 같은 변수는 메모리에 기억 장소를 둔다. "
                + "모든 변수는 이름, 유형, 크기, 값이 있다. 6번 줄은 radius에 double(실수) 형의 값을 기억하도록 한 것이며, radius 변수의 값은 값을 할당하기 전까지는 결정되지 않는다."
                + "</color>";

            if (Code2Generator.instance.code2_7 != null)
            {
                Destroy(Code2Generator.instance.code2_7);
            }
            else
            {; }
            if (this.s2_7 != null)
            {
                Destroy(this.s2_7);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_8" && Code2Generator.instance.array2[3] == 8 && count == 3)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(53.88f, -3.85f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "radius와 같은 변수는 메모리에 기억 장소를 둔다. "
                + "모든 변수는 이름, 유형, 크기, 값이 있다. 6번 줄은 radius에 double(실수) 형의 값을 기억하도록 한 것이며, radius 변수의 값은 값을 할당하기 전까지는 결정되지 않는다."
                + "</color>";

            if (Code2Generator.instance.code2_8 != null)
            {
                Destroy(Code2Generator.instance.code2_8);
            }
            else
            {; }
            if (this.s2_8 != null)
            {
                Destroy(this.s2_8);
            }
            else
            {; }
            count++;
        }

        if (other.gameObject.tag == "s2_0" && Code2Generator.instance.array2[4] == 0 && count == 4)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(53.88f, -4.31f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "area와 같은 변수는 메모리에 기억 장소를 둔다. "
                + "모든 변수는 이름, 유형, 크기, 값이 있다. 7번 줄은 area에 double(실수) 형의 값을 기억하도록 한 것이며, area 변수의 값은 할당하기 전까지는 결정되지 않는다."
                + "</color>";

            if (Code2Generator.instance.code2_0 != null)
            {
                Destroy(Code2Generator.instance.code2_0);
            }
            else
            {; }
            if (this.s2_0 != null)
            {
                Destroy(this.s2_0);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_1" && Code2Generator.instance.array2[4] == 1 && count == 4)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(53.88f, -4.31f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "area와 같은 변수는 메모리에 기억 장소를 둔다. "
                + "모든 변수는 이름, 유형, 크기, 값이 있다. 7번 줄은 area에 double(실수) 형의 값을 기억하도록 한 것이며, area 변수의 값은 할당하기 전까지는 결정되지 않는다."
                + "</color>";

            if (Code2Generator.instance.code2_1 != null)
            {
                Destroy(Code2Generator.instance.code2_1);
            }
            else
            {; }
            if (this.s2_1 != null)
            {
                Destroy(this.s2_1);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_2" && Code2Generator.instance.array2[4] == 2 && count == 4)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(53.88f, -4.31f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "area와 같은 변수는 메모리에 기억 장소를 둔다. "
                + "모든 변수는 이름, 유형, 크기, 값이 있다. 7번 줄은 area에 double(실수) 형의 값을 기억하도록 한 것이며, area 변수의 값은 할당하기 전까지는 결정되지 않는다."
                + "</color>";

            if (Code2Generator.instance.code2_2 != null)
            {
                Destroy(Code2Generator.instance.code2_2);
            }
            else
            {; }
            if (this.s2_2 != null)
            {
                Destroy(this.s2_2);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_3" && Code2Generator.instance.array2[4] == 3 && count == 4)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(53.88f, -4.31f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "area와 같은 변수는 메모리에 기억 장소를 둔다. "
                + "모든 변수는 이름, 유형, 크기, 값이 있다. 7번 줄은 area에 double(실수) 형의 값을 기억하도록 한 것이며, area 변수의 값은 할당하기 전까지는 결정되지 않는다."
                + "</color>";

            if (Code2Generator.instance.code2_3 != null)
            {
                Destroy(Code2Generator.instance.code2_3);
            }
            else
            {; }
            if (this.s2_3 != null)
            {
                Destroy(this.s2_3);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_4" && Code2Generator.instance.array2[4] == 4 && count == 4)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(53.88f, -4.31f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "area와 같은 변수는 메모리에 기억 장소를 둔다. "
                + "모든 변수는 이름, 유형, 크기, 값이 있다. 7번 줄은 area에 double(실수) 형의 값을 기억하도록 한 것이며, area 변수의 값은 할당하기 전까지는 결정되지 않는다."
                + "</color>";

            if (Code2Generator.instance.code2_4 != null)
            {
                Destroy(Code2Generator.instance.code2_4);
            }
            else
            {; }
            if (this.s2_4 != null)
            {
                Destroy(this.s2_4);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_5" && Code2Generator.instance.array2[4] == 5 && count == 4)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(53.88f, -4.31f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "area와 같은 변수는 메모리에 기억 장소를 둔다. "
                + "모든 변수는 이름, 유형, 크기, 값이 있다. 7번 줄은 area에 double(실수) 형의 값을 기억하도록 한 것이며, area 변수의 값은 할당하기 전까지는 결정되지 않는다."
                + "</color>";

            if (Code2Generator.instance.code2_5 != null)
            {
                Destroy(Code2Generator.instance.code2_5);
            }
            else
            {; }
            if (this.s2_5 != null)
            {
                Destroy(this.s2_5);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_6" && Code2Generator.instance.array2[4] == 6 && count == 4)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(53.88f, -4.31f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "area와 같은 변수는 메모리에 기억 장소를 둔다. "
                + "모든 변수는 이름, 유형, 크기, 값이 있다. 7번 줄은 area에 double(실수) 형의 값을 기억하도록 한 것이며, area 변수의 값은 할당하기 전까지는 결정되지 않는다."
                + "</color>";

            if (Code2Generator.instance.code2_6 != null)
            {
                Destroy(Code2Generator.instance.code2_6);
            }
            else
            {; }
            if (this.s2_6 != null)
            {
                Destroy(this.s2_6);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_7" && Code2Generator.instance.array2[4] == 7 && count == 4)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(53.88f, -4.31f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "area와 같은 변수는 메모리에 기억 장소를 둔다. "
                + "모든 변수는 이름, 유형, 크기, 값이 있다. 7번 줄은 area에 double(실수) 형의 값을 기억하도록 한 것이며, area 변수의 값은 할당하기 전까지는 결정되지 않는다."
                + "</color>";


            if (Code2Generator.instance.code2_7 != null)
            {
                Destroy(Code2Generator.instance.code2_7);
            }
            else
            {; }
            if (this.s2_7 != null)
            {
                Destroy(this.s2_7);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_8" && Code2Generator.instance.array2[4] == 8 && count == 4)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(53.88f, -4.31f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "area와 같은 변수는 메모리에 기억 장소를 둔다. "
                + "모든 변수는 이름, 유형, 크기, 값이 있다. 7번 줄은 area에 double(실수) 형의 값을 기억하도록 한 것이며, area 변수의 값은 할당하기 전까지는 결정되지 않는다."
                + "</color>";

            if (Code2Generator.instance.code2_8 != null)
            {
                Destroy(Code2Generator.instance.code2_8);
            }
            else
            {; }
            if (this.s2_8 != null)
            {
                Destroy(this.s2_8);
            }
            else
            {; }
            count++;
        }

        if (other.gameObject.tag == "s2_0" && Code2Generator.instance.array2[5] == 0 && count == 5)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(56.24f, -4.82f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "radius라는 이름을 가진 변수에 20을 할당하였다." + "</color>";

            if (Code2Generator.instance.code2_0 != null)
            {
                Destroy(Code2Generator.instance.code2_0);
            }
            else
            {; }
            if (this.s2_0 != null)
            {
                Destroy(this.s2_0);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_1" && Code2Generator.instance.array2[5] == 1 && count == 5)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(56.24f, -4.82f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "radius라는 이름을 가진 변수에 20을 할당하였다." + "</color>";

            if (Code2Generator.instance.code2_1 != null)
            {
                Destroy(Code2Generator.instance.code2_1);
            }
            else
            {; }
            if (this.s2_1 != null)
            {
                Destroy(this.s2_1);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_2" && Code2Generator.instance.array2[5] == 2 && count == 5)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(56.24f, -4.82f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "radius라는 이름을 가진 변수에 20을 할당하였다." + "</color>";

            if (Code2Generator.instance.code2_2 != null)
            {
                Destroy(Code2Generator.instance.code2_2);
            }
            else
            {; }
            if (this.s2_2 != null)
            {
                Destroy(this.s2_2);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_3" && Code2Generator.instance.array2[5] == 3 && count == 5)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(56.24f, -4.82f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "radius라는 이름을 가진 변수에 20을 할당하였다." + "</color>";

            if (Code2Generator.instance.code2_3 != null)
            {
                Destroy(Code2Generator.instance.code2_3);
            }
            else
            {; }
            if (this.s2_3 != null)
            {
                Destroy(this.s2_3);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_4" && Code2Generator.instance.array2[5] == 4 && count == 5)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(56.24f, -4.82f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "radius라는 이름을 가진 변수에 20을 할당하였다." + "</color>";

            if (Code2Generator.instance.code2_4 != null)
            {
                Destroy(Code2Generator.instance.code2_4);
            }
            else
            {; }
            if (this.s2_4 != null)
            {
                Destroy(this.s2_4);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_5" && Code2Generator.instance.array2[5] == 5 && count == 5)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(56.24f, -4.82f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "radius라는 이름을 가진 변수에 20을 할당하였다." + "</color>";

            if (Code2Generator.instance.code2_5 != null)
            {
                Destroy(Code2Generator.instance.code2_5);
            }
            else
            {; }
            if (this.s2_5 != null)
            {
                Destroy(this.s2_5);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_6" && Code2Generator.instance.array2[5] == 6 && count == 5)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(56.24f, -4.82f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "radius라는 이름을 가진 변수에 20을 할당하였다." + "</color>";

            if (Code2Generator.instance.code2_6 != null)
            {
                Destroy(Code2Generator.instance.code2_6);
            }
            else
            {; }
            if (this.s2_6 != null)
            {
                Destroy(this.s2_6);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_7" && Code2Generator.instance.array2[5] == 7 && count == 5)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(56.24f, -4.82f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "radius라는 이름을 가진 변수에 20을 할당하였다." + "</color>";

            if (Code2Generator.instance.code2_7 != null)
            {
                Destroy(Code2Generator.instance.code2_7);
            }
            else
            {; }
            if (this.s2_7 != null)
            {
                Destroy(this.s2_7);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_8" && Code2Generator.instance.array2[5] == 8 && count == 5)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(56.24f, -4.82f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "radius라는 이름을 가진 변수에 20을 할당하였다." + "</color>";

            if (Code2Generator.instance.code2_8 != null)
            {
                Destroy(Code2Generator.instance.code2_8);
            }
            else
            {; }
            if (this.s2_8 != null)
            {
                Destroy(this.s2_8);
            }
            else
            {; }
            count++;
        }

        if (other.gameObject.tag == "s2_0" && Code2Generator.instance.array2[6] == 0 && count == 6)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(56.91f, -5.33f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "9번 줄에서 radius에 20이 할당 되었으므로 (20 * 20 * 3.14159)를 계산한 값이 area(실수)에 할당된다."
            + "</color>";

            if (Code2Generator.instance.code2_0 != null)
            {
                Destroy(Code2Generator.instance.code2_0);
            }
            else
            {; }
            if (this.s2_0 != null)
            {
                Destroy(this.s2_0);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_1" && Code2Generator.instance.array2[6] == 1 && count == 6)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(56.91f, -5.33f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "9번 줄에서 radius에 20이 할당 되었으므로 (20 * 20 * 3.14159)를 계산한 값이 area(실수)에 할당된다."
            + "</color>";

            if (Code2Generator.instance.code2_1 != null)
            {
                Destroy(Code2Generator.instance.code2_1);
            }
            else
            {; }
            if (this.s2_1 != null)
            {
                Destroy(this.s2_1);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_2" && Code2Generator.instance.array2[6] == 2 && count == 6)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(56.91f, -5.33f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "9번 줄에서 radius에 20이 할당 되었으므로 (20 * 20 * 3.14159)를 계산한 값이 area(실수)에 할당된다."
            + "</color>";

            if (Code2Generator.instance.code2_2 != null)
            {
                Destroy(Code2Generator.instance.code2_2);
            }
            else
            {; }
            if (this.s2_2 != null)
            {
                Destroy(this.s2_2);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_3" && Code2Generator.instance.array2[6] == 3 && count == 6)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(56.91f, -5.33f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "9번 줄에서 radius에 20이 할당 되었으므로 (20 * 20 * 3.14159)를 계산한 값이 area(실수)에 할당된다."
            + "</color>";

            if (Code2Generator.instance.code2_3 != null)
            {
                Destroy(Code2Generator.instance.code2_3);
            }
            else
            {; }
            if (this.s2_3 != null)
            {
                Destroy(this.s2_3);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_4" && Code2Generator.instance.array2[6] == 4 && count == 6)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(56.91f, -5.33f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "9번 줄에서 radius에 20이 할당 되었으므로 (20 * 20 * 3.14159)를 계산한 값이 area(실수)에 할당된다."
            + "</color>";

            if (Code2Generator.instance.code2_4 != null)
            {
                Destroy(Code2Generator.instance.code2_4);
            }
            else
            {; }
            if (this.s2_4 != null)
            {
                Destroy(this.s2_4);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_5" && Code2Generator.instance.array2[6] == 5 && count == 6)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(56.91f, -5.33f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "9번 줄에서 radius에 20이 할당 되었으므로 (20 * 20 * 3.14159)를 계산한 값이 area(실수)에 할당된다."
            + "</color>";

            if (Code2Generator.instance.code2_5 != null)
            {
                Destroy(Code2Generator.instance.code2_5);
            }
            else
            {; }
            if (this.s2_5 != null)
            {
                Destroy(this.s2_5);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_6" && Code2Generator.instance.array2[6] == 6 && count == 6)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(56.91f, -5.33f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "9번 줄에서 radius에 20이 할당 되었으므로 (20 * 20 * 3.14159)를 계산한 값이 area(실수)에 할당된다."
            + "</color>";

            if (Code2Generator.instance.code2_6 != null)
            {
                Destroy(Code2Generator.instance.code2_6);
            }
            else
            {; }
            if (this.s2_6 != null)
            {
                Destroy(this.s2_6);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_7" && Code2Generator.instance.array2[6] == 7 && count == 6)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(56.91f, -5.33f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "9번 줄에서 radius에 20이 할당 되었으므로 (20 * 20 * 3.14159)를 계산한 값이 area(실수)에 할당된다."
            + "</color>";

            if (Code2Generator.instance.code2_7 != null)
            {
                Destroy(Code2Generator.instance.code2_7);
            }
            else
            {; }
            if (this.s2_7 != null)
            {
                Destroy(this.s2_7);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_8" && Code2Generator.instance.array2[6] == 8 && count == 6)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(56.91f, -5.33f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "9번 줄에서 radius에 20이 할당 되었으므로 (20 * 20 * 3.14159)를 계산한 값(이 값은 1256.64이다.)"
            + "이 area(실수)에 할당된다."
            + "</color>";

            if (Code2Generator.instance.code2_8 != null)
            {
                Destroy(Code2Generator.instance.code2_8);
            }
            else
            {; }
            if (this.s2_8 != null)
            {
                Destroy(this.s2_8);
            }
            else
            {; }
            count++;
        }

        if (other.gameObject.tag == "s2_0" && Code2Generator.instance.array2[7] == 0 && count == 7)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(53.57f, -5.84f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "The area is 가 콘솔에 출력되고 11번 줄에서 (20 * 20 * 3.14159)를 계산한 값이 area에 할당되었으므로 "
            + "\"The area is 1256.64\"가 콘솔에 출력된다." + "</color>";

            if (Code2Generator.instance.code2_0 != null)
            {
                Destroy(Code2Generator.instance.code2_0);
            }
            else
            {; }
            if (this.s2_0 != null)
            {
                Destroy(this.s2_0);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_1" && Code2Generator.instance.array2[7] == 1 && count == 7)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(53.57f, -5.84f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "The area is 가 콘솔에 출력되고 11번 줄에서 (20 * 20 * 3.14159)를 계산한 값이 area에 할당되었으므로 "
            + "\"The area is 1256.64\"가 콘솔에 출력된다." + "</color>";

            if (Code2Generator.instance.code2_1 != null)
            {
                Destroy(Code2Generator.instance.code2_1);
            }
            else
            {; }
            if (this.s2_1 != null)
            {
                Destroy(this.s2_1);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_2" && Code2Generator.instance.array2[7] == 2 && count == 7)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(53.57f, -5.84f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "The area is 가 콘솔에 출력되고 11번 줄에서 (20 * 20 * 3.14159)를 계산한 값이 area에 할당되었으므로 "
            + "\"The area is 1256.64\"가 콘솔에 출력된다." + "</color>";

            if (Code2Generator.instance.code2_2 != null)
            {
                Destroy(Code2Generator.instance.code2_2);
            }
            else
            {; }
            if (this.s2_2 != null)
            {
                Destroy(this.s2_2);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_3" && Code2Generator.instance.array2[7] == 3 && count == 7)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(53.57f, -5.84f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "The area is 가 콘솔에 출력되고 11번 줄에서 (20 * 20 * 3.14159)를 계산한 값이 area에 할당되었으므로 "
            + "\"The area is 1256.64\"가 콘솔에 출력된다." + "</color>";

            if (Code2Generator.instance.code2_3 != null)
            {
                Destroy(Code2Generator.instance.code2_3);
            }
            else
            {; }
            if (this.s2_3 != null)
            {
                Destroy(this.s2_3);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_4" && Code2Generator.instance.array2[7] == 4 && count == 7)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(53.57f, -5.84f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "The area is 가 콘솔에 출력되고 11번 줄에서 (20 * 20 * 3.14159)를 계산한 값이 area에 할당되었으므로 "
            + "\"The area is 1256.64\"가 콘솔에 출력된다." + "</color>";

            if (Code2Generator.instance.code2_4 != null)
            {
                Destroy(Code2Generator.instance.code2_4);
            }
            else
            {; }
            if (this.s2_4 != null)
            {
                Destroy(this.s2_4);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_5" && Code2Generator.instance.array2[7] == 5 && count == 7)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(53.57f, -5.84f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "The area is 가 콘솔에 출력되고 11번 줄에서 (20 * 20 * 3.14159)를 계산한 값이 area에 할당되었으므로 "
            + "\"The area is 1256.64\"가 콘솔에 출력된다." + "</color>";

            if (Code2Generator.instance.code2_5 != null)
            {
                Destroy(Code2Generator.instance.code2_5);
            }
            else
            {; }
            if (this.s2_5 != null)
            {
                Destroy(this.s2_5);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_6" && Code2Generator.instance.array2[7] == 6 && count == 7)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(53.57f, -5.84f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "The area is 가 콘솔에 출력되고 11번 줄에서 (20 * 20 * 3.14159)를 계산한 값이 area에 할당되었으므로 "
            + "\"The area is 1256.64\"가 콘솔에 출력된다." + "</color>";

            if (Code2Generator.instance.code2_6 != null)
            {
                Destroy(Code2Generator.instance.code2_6);
            }
            else
            {; }
            if (this.s2_6 != null)
            {
                Destroy(this.s2_6);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_7" && Code2Generator.instance.array2[7] == 7 && count == 7)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(53.57f, -5.84f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "The area is 가 콘솔에 출력되고 11번 줄에서 (20 * 20 * 3.14159)를 계산한 값이 area에 할당되었으므로 "
            + "\"The area is 1256.64\"가 콘솔에 출력된다." + "</color>";

            if (Code2Generator.instance.code2_7 != null)
            {
                Destroy(Code2Generator.instance.code2_7);
            }
            else
            {; }
            if (this.s2_7 != null)
            {
                Destroy(this.s2_7);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_8" && Code2Generator.instance.array2[7] == 8 && count == 7)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle2.transform.position = new Vector3(53.57f, -5.84f, 0);

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "The area is 가 콘솔에 출력되고 11번 줄에서 (20 * 20 * 3.14159)를 계산한 값이 area에 할당되었으므로 "
            + "\"The area is 1256.64\"가 콘솔에 출력된다." + "</color>";

            if (Code2Generator.instance.code2_8 != null)
            {
                Destroy(Code2Generator.instance.code2_8);
            }
            else
            {; }
            if (this.s2_8 != null)
            {
                Destroy(this.s2_8);
            }
            else
            {; }
            count++;
        }

        if (other.gameObject.tag == "s2_0" && Code2Generator.instance.array2[8] == 0 && count == 8)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();
            this.transform.position = new Vector3(61.55f, -2.5f, 0);
            this.talk.transform.position = new Vector3(61.71f, -3.26f, 0);
            this.Talk2.GetComponent<Text>().text = "<color=white>" + "수고했어요! 기초코드공부 끝! 초기화면으로 돌아가려면 엔터를 눌러주세요!" + "</color>";

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "return 0;은 프로그램의 맨 마지막에 작성되어 있으며 프로그램이 종료(exit) 되는 것을 의미한다. "
            + "값이 0인 것은 프로그램이 정상적인 종료가 되었음을 의미하는 것이다. " + "이 문장은 생략할 경우 컴파일러에 따라 프로그램이 잘 동작하거나 아니면 오류를 "
            + "발생시킬 수 있다. 그러므로 모든 C++ 컴파일러에서 작성 중인 프로그램이 잘 동작하게 하려면 이 문장을 항상 포함시키는 것이 좋다." + "</color>";

            isAlive = false;
            isAlive1 = true;

            if (Code2Generator.instance.code2_0 != null)
            {
                Destroy(Code2Generator.instance.code2_0);
            }
            else
            {; }
            if (this.s2_0 != null)
            {
                Destroy(this.s2_0);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_1" && Code2Generator.instance.array2[8] == 1 && count == 8)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();
            this.transform.position = new Vector3(61.55f, -2.5f, 0);
            this.talk.transform.position = new Vector3(61.71f, -3.26f, 0);
            this.Talk2.GetComponent<Text>().text = "<color=white>" + "수고했어요! 기초코드공부 끝! 초기화면으로 돌아가려면 엔터를 눌러주세요!" + "</color>";

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "return 0;은 프로그램의 맨 마지막에 작성되어 있으며 프로그램이 종료(exit) 되는 것을 의미한다. "
            + "값이 0인 것은 프로그램이 정상적인 종료가 되었음을 의미하는 것이다. " + "이 문장은 생략할 경우 컴파일러에 따라 프로그램이 잘 동작하거나 아니면 오류를 "
            + "발생시킬 수 있다. 그러므로 모든 C++ 컴파일러에서 작성 중인 프로그램이 잘 동작하게 하려면 이 문장을 항상 포함시키는 것이 좋다." + "</color>";

            isAlive = false;
            isAlive = true;

            if (Code2Generator.instance.code2_1 != null)
            {
                Destroy(Code2Generator.instance.code2_1);
            }
            else
            {; }
            if (this.s2_1 != null)
            {
                Destroy(this.s2_1);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_2" && Code2Generator.instance.array2[8] == 2 && count == 8)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();
            this.transform.position = new Vector3(61.55f, -2.5f, 0);
            this.talk.transform.position = new Vector3(61.71f, -3.26f, 0);
            this.Talk2.GetComponent<Text>().text = "<color=white>" + "수고했어요! 기초코드공부 끝! 초기화면으로 돌아가려면 엔터를 눌러주세요!" + "</color>";

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "return 0;은 프로그램의 맨 마지막에 작성되어 있으며 프로그램이 종료(exit) 되는 것을 의미한다. "
            + "값이 0인 것은 프로그램이 정상적인 종료가 되었음을 의미하는 것이다. " + "이 문장은 생략할 경우 컴파일러에 따라 프로그램이 잘 동작하거나 아니면 오류를 "
            + "발생시킬 수 있다. 그러므로 모든 C++ 컴파일러에서 작성 중인 프로그램이 잘 동작하게 하려면 이 문장을 항상 포함시키는 것이 좋다." + "</color>";

            isAlive = false;
            isAlive1 = true;

            if (Code2Generator.instance.code2_2 != null)
            {
                Destroy(Code2Generator.instance.code2_2);
            }
            else
            {; }
            if (this.s2_2 != null)
            {
                Destroy(this.s2_2);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_3" && Code2Generator.instance.array2[8] == 3 && count == 8)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();
            this.transform.position = new Vector3(61.55f, -2.5f, 0);
            this.talk.transform.position = new Vector3(61.71f, -3.26f, 0);
            this.Talk2.GetComponent<Text>().text = "<color=white>" + "수고했어요! 기초코드공부 끝! 초기화면으로 돌아가려면 엔터를 눌러주세요!" + "</color>";

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "return 0;은 프로그램의 맨 마지막에 작성되어 있으며 프로그램이 종료(exit) 되는 것을 의미한다. "
            + "값이 0인 것은 프로그램이 정상적인 종료가 되었음을 의미하는 것이다. " + "이 문장은 생략할 경우 컴파일러에 따라 프로그램이 잘 동작하거나 아니면 오류를 "
            + "발생시킬 수 있다. 그러므로 모든 C++ 컴파일러에서 작성 중인 프로그램이 잘 동작하게 하려면 이 문장을 항상 포함시키는 것이 좋다." + "</color>";

            isAlive = false;
            isAlive1 = true;

            if (Code2Generator.instance.code2_3 != null)
            {
                Destroy(Code2Generator.instance.code2_3);
            }
            else
            {; }
            if (this.s2_3 != null)
            {
                Destroy(this.s2_3);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_4" && Code2Generator.instance.array2[8] == 4 && count == 8)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();
            this.transform.position = new Vector3(61.55f, -2.5f, 0);
            this.talk.transform.position = new Vector3(61.71f, -3.26f, 0);
            this.Talk2.GetComponent<Text>().text = "<color=white>" + "수고했어요! 기초코드공부 끝! 초기화면으로 돌아가려면 엔터를 눌러주세요!" + "</color>";

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "return 0;은 프로그램의 맨 마지막에 작성되어 있으며 프로그램이 종료(exit) 되는 것을 의미한다. "
            + "값이 0인 것은 프로그램이 정상적인 종료가 되었음을 의미하는 것이다. " + "이 문장은 생략할 경우 컴파일러에 따라 프로그램이 잘 동작하거나 아니면 오류를 "
            + "발생시킬 수 있다. 그러므로 모든 C++ 컴파일러에서 작성 중인 프로그램이 잘 동작하게 하려면 이 문장을 항상 포함시키는 것이 좋다." + "</color>";

            isAlive = false;
            isAlive1 = true;

            if (Code2Generator.instance.code2_4 != null)
            {
                Destroy(Code2Generator.instance.code2_4);
            }
            else
            {; }
            if (this.s2_4 != null)
            {
                Destroy(this.s2_4);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_5" && Code2Generator.instance.array2[8] == 5 && count == 8)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();
            this.transform.position = new Vector3(61.55f, -3.0f, 0);
            this.talk.transform.position = new Vector3(61.71f, -3.26f, 0);
            this.Talk2.GetComponent<Text>().text = "<color=white>" + "수고했어요! 기초코드공부 끝! 초기화면으로 돌아가려면 엔터를 눌러주세요!" + "</color>";

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "return 0;은 프로그램의 맨 마지막에 작성되어 있으며 프로그램이 종료(exit) 되는 것을 의미한다. "
            + "값이 0인 것은 프로그램이 정상적인 종료가 되었음을 의미하는 것이다. " + "이 문장은 생략할 경우 컴파일러에 따라 프로그램이 잘 동작하거나 아니면 오류를 "
            + "발생시킬 수 있다. 그러므로 모든 C++ 컴파일러에서 작성 중인 프로그램이 잘 동작하게 하려면 이 문장을 항상 포함시키는 것이 좋다." + "</color>";

            isAlive = false;
            isAlive1 = true;

            if (Code2Generator.instance.code2_5 != null)
            {
                Destroy(Code2Generator.instance.code2_5);
            }
            else
            {; }
            if (this.s2_5 != null)
            {
                Destroy(this.s2_5);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_6" && Code2Generator.instance.array2[8] == 6 && count == 8)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();
            this.transform.position = new Vector3(61.55f, -2.5f, 0);
            this.talk.transform.position = new Vector3(61.71f, -3.26f, 0);
            this.Talk2.GetComponent<Text>().text = "<color=white>" + "수고했어요! 기초코드공부 끝! 초기화면으로 돌아가려면 엔터를 눌러주세요!" + "</color>";

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "return 0;은 프로그램의 맨 마지막에 작성되어 있으며 프로그램이 종료(exit) 되는 것을 의미한다. "
            + "값이 0인 것은 프로그램이 정상적인 종료가 되었음을 의미하는 것이다. " + "이 문장은 생략할 경우 컴파일러에 따라 프로그램이 잘 동작하거나 아니면 오류를 "
            + "발생시킬 수 있다. 그러므로 모든 C++ 컴파일러에서 작성 중인 프로그램이 잘 동작하게 하려면 이 문장을 항상 포함시키는 것이 좋다." + "</color>";

            isAlive = false;
            isAlive1 = true;

            if (Code2Generator.instance.code2_6 != null)
            {
                Destroy(Code2Generator.instance.code2_6);
            }
            else
            {; }
            if (this.s2_6 != null)
            {
                Destroy(this.s2_6);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_7" && Code2Generator.instance.array2[8] == 7 && count == 8)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();
            this.transform.position = new Vector3(61.55f, -2.5f, 0);
            this.talk.transform.position = new Vector3(61.71f, -3.26f, 0);
            this.Talk2.GetComponent<Text>().text = "<color=white>" + "수고했어요! 기초코드공부 끝! 초기화면으로 돌아가려면 엔터를 눌러주세요!" + "</color>";

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "return 0;은 프로그램의 맨 마지막에 작성되어 있으며 프로그램이 종료(exit) 되는 것을 의미한다. "
            + "값이 0인 것은 프로그램이 정상적인 종료가 되었음을 의미하는 것이다. " + "이 문장은 생략할 경우 컴파일러에 따라 프로그램이 잘 동작하거나 아니면 오류를 "
            + "발생시킬 수 있다. 그러므로 모든 C++ 컴파일러에서 작성 중인 프로그램이 잘 동작하게 하려면 이 문장을 항상 포함시키는 것이 좋다." + "</color>";

            isAlive = false;
            isAlive1 = true;

            if (Code2Generator.instance.code2_7 != null)
            {
                Destroy(Code2Generator.instance.code2_7);
            }
            else
            {; }
            if (this.s2_7 != null)
            {
                Destroy(this.s2_7);
            }
            else
            {; }
            count++;
        }
        else if (other.gameObject.tag == "s2_8" && Code2Generator.instance.array2[8] == 8 && count == 8)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, 1);
            this.particle.GetComponent<ParticleSystem>().Play();
            this.transform.position = new Vector3(61.55f, -2.5f, 0);
            this.talk.transform.position = new Vector3(61.71f, -3.26f, 0);
            this.Talk2.GetComponent<Text>().text = "<color=white>" + "수고했어요! 기초코드공부 끝! 초기화면으로 돌아가려면 엔터를 눌러주세요!" + "</color>";

            this.explain2.GetComponent<Text>().text = "";
            this.explain2.GetComponent<Text>().text = "<color=white>" + "return 0;은 프로그램의 맨 마지막에 작성되어 있으며 프로그램이 종료(exit) 되는 것을 의미한다. "
            + "값이 0인 것은 프로그램이 정상적인 종료가 되었음을 의미하는 것이다. " + "이 문장은 생략할 경우 컴파일러에 따라 프로그램이 잘 동작하거나 아니면 오류를 "
            + "발생시킬 수 있다. 그러므로 모든 C++ 컴파일러에서 작성 중인 프로그램이 잘 동작하게 하려면 이 문장을 항상 포함시키는 것이 좋다." + "</color>";

            isAlive = false;
            isAlive1 = true;

            if (Code2Generator.instance.code2_8 != null)
            {
                Destroy(Code2Generator.instance.code2_8);
            }
            else
            {; }
            if (this.s2_8 != null)
            {
                Destroy(this.s2_8);
            }
            else
            {; }
            count++;
        }
    }


    void Start()
    {
        count = 0;

        this.s2_0 = GameObject.Find("s2_0");
        this.s2_1 = GameObject.Find("s2_1");
        this.s2_2 = GameObject.Find("s2_2");
        this.s2_3 = GameObject.Find("s2_3");
        this.s2_4 = GameObject.Find("s2_4");
        this.s2_5 = GameObject.Find("s2_5");
        this.s2_6 = GameObject.Find("s2_6");
        this.s2_7 = GameObject.Find("s2_7");
        this.s2_8 = GameObject.Find("s2_8");

        this.explain2 = GameObject.Find("explain2");
        this.particle = GameObject.Find("Particle System");
        this.circle2 = GameObject.Find("circle2");
        this.talk = GameObject.Find("talk");
        this.Talk2 = GameObject.Find("Talk2");
        this.cam = GameObject.Find("Main Camera");
    }

    void Update()
    {

        if (Superman1Controller.instance.code2Count == 1 && isAlive == true)
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Translate(moveSpeed * Time.deltaTime, 0, 0);
                this.transform.localScale = new Vector3(0.65f, 0.65f, 0);
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Translate(-moveSpeed * Time.deltaTime, 0, 0);
                this.transform.localScale = new Vector3(-0.65f, 0.65f, 0);
            }
            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.Translate(0, moveSpeed * Time.deltaTime, 0);
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.Translate(0, -moveSpeed * Time.deltaTime, 0);
            }
        }

        if (isAlive1 == true)
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                homeworkAudioManager.instance.AudioDestroy();

                PlayerPrefs.SetString("HomeworkR", "P");
                if (PlayerPrefs.GetInt("retry") == 0)
                {
                    GameObject.Find("GameManager").GetComponent<GameManager>().saveCalDate(13);
                    SceneManager.LoadScene("calendarScene");
                }
                else if (PlayerPrefs.GetInt("retry") == 1)
                {
                    SceneManager.LoadScene("endScene");
                }

            }
        }
        if (this.transform.position.x >= 69.7f || this.transform.position.x <= 50.3f)
        {
            this.transform.position = new Vector3(61.55f, -3.42f, 0);
        }
        else if (this.transform.position.y >= 5.0f || this.transform.position.y <= -7.0f)
        {
            this.transform.position = new Vector3(61.55f, -3.42f, 0);
        }

    }
}
