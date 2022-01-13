using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Superman1Controller : MonoBehaviour
{
    public static Superman1Controller instance = null;

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
    public int code2Count;
    float moveSpeed = 4.0f;

    GameObject s1_0;
    GameObject s1_1;
    GameObject s1_2;
    GameObject s1_3;
    GameObject s1_4;
    GameObject s1_5;

    GameObject explain1;
    GameObject particle;
    GameObject circle1;
    GameObject talk;
    GameObject Talk1;
    GameObject cam;

    bool isAlive = true;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "s1_0" && Code1Generator.instance.array1[0] == 0 && count == 0)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle1.transform.position = new Vector3(24.33f, -2.53f);

            this.explain1.GetComponent<Text>().text = "<color=white>" + "#include <iostream>은 컴파일러 전처리기 지시자로 컴파일러로 하여금 화면 입출력을 위해 이 프로그램에 "
            + "iostream 라이브러리를 포함하도록 한다. C++ 라이브러리에는 C++ 프로그램 개발을 위해 미리 정의된 코드가 포함되어 있다. "
            + "iostream 같은 라이브러리는 C++에서 헤더 파일이라고 하는데, 보통 프로그램의 상단에 위치하기 때문이다." + "</color>";
            if (Code1Generator.instance.code1_0 != null)
            {
                Destroy(Code1Generator.instance.code1_0);
            }
            else
            { ;}
            if (this.s1_0 != null)
            {
                Destroy(this.s1_0);
            }
            else
            { ;}
            count++;
        }
        else if (other.gameObject.tag == "s1_1" && Code1Generator.instance.array1[0] == 1 && count == 0)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle1.transform.position = new Vector3(24.33f, -2.53f);

            this.explain1.GetComponent<Text>().text = "<color=white>" + "#include <iostream>은 컴파일러 전처리기 지시자로 컴파일러로 하여금 화면 입출력을 위해 이 프로그램에 "
            + "iostream 라이브러리를 포함하도록 한다. C++ 라이브러리에는 C++ 프로그램 개발을 위해 미리 정의된 코드가 포함되어 있다. "
            + "iostream 같은 라이브러리는 C++에서 헤더 파일이라고 하는데, 보통 프로그램의 상단에 위치하기 때문이다." + "</color>";
            
            if (Code1Generator.instance.code1_1 != null)
            {
                Destroy(Code1Generator.instance.code1_1);
            }
            else
            { ;}
            if (this.s1_1 != null)
            {
                Destroy(this.s1_1);
            }
            else
            { ;}
            count++;
        }
        else if (other.gameObject.tag == "s1_2" && Code1Generator.instance.array1[0] == 2 && count == 0)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle1.transform.position = new Vector3(24.33f, -2.53f);

            this.explain1.GetComponent<Text>().text = "<color=white>" + "#include <iostream>은 컴파일러 전처리기 지시자로 컴파일러로 하여금 화면 입출력을 위해 이 프로그램에 "
            + "iostream 라이브러리를 포함하도록 한다. C++ 라이브러리에는 C++ 프로그램 개발을 위해 미리 정의된 코드가 포함되어 있다. "
            + "iostream 같은 라이브러리는 C++에서 헤더 파일이라고 하는데, 보통 프로그램의 상단에 위치하기 때문이다." + "</color>";
            
            if (Code1Generator.instance.code1_2 != null)
            {
                Destroy(Code1Generator.instance.code1_2);
            }
            else
            { ;}
            if (this.s1_2 != null)
            {
                Destroy(this.s1_2);
            }
            else
            { ;}
            count++;
        }
        else if (other.gameObject.tag == "s1_3" && Code1Generator.instance.array1[0] == 3 && count == 0)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle1.transform.position = new Vector3(24.33f, -2.53f);

            this.explain1.GetComponent<Text>().text = "<color=white>" + "#include <iostream>은 컴파일러 전처리기 지시자로 컴파일러로 하여금 화면 입출력을 위해 이 프로그램에 "
            + "iostream 라이브러리를 포함하도록 한다. C++ 라이브러리에는 C++ 프로그램 개발을 위해 미리 정의된 코드가 포함되어 있다. "
            + "iostream 같은 라이브러리는 C++에서 헤더 파일이라고 하는데, 보통 프로그램의 상단에 위치하기 때문이다." + "</color>";

            if (Code1Generator.instance.code1_3 != null)
            {
                Destroy(Code1Generator.instance.code1_3);
            }
            else
            { ;}
            if (this.s1_3 != null)
            {
                Destroy(this.s1_3);
            }
            else
            { ;}
            count++;
        }
        else if (other.gameObject.tag == "s1_4" && Code1Generator.instance.array1[0] == 4 && count == 0)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle1.transform.position = new Vector3(24.33f, -2.53f);

            this.explain1.GetComponent<Text>().text = "<color=white>" + "#include <iostream>은 컴파일러 전처리기 지시자로 컴파일러로 하여금 화면 입출력을 위해 이 프로그램에 "
            + "iostream 라이브러리를 포함하도록 한다. C++ 라이브러리에는 C++ 프로그램 개발을 위해 미리 정의된 코드가 포함되어 있다. "
            + "iostream 같은 라이브러리는 C++에서 헤더 파일이라고 하는데, 보통 프로그램의 상단에 위치하기 때문이다." + "</color>";

            if (Code1Generator.instance.code1_4 != null)
            {
                Destroy(Code1Generator.instance.code1_4);
            }
            else
            { ;}
            if (this.s1_4 != null)
            {
                Destroy(this.s1_4);
            }
            else
            { ;}
            count++;
        }
        else if (other.gameObject.tag == "s1_5" && Code1Generator.instance.array1[0] == 5 && count == 0)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle1.transform.position = new Vector3(24.33f, -2.53f);

            this.explain1.GetComponent<Text>().text = "<color=white>" + "#include <iostream>은 컴파일러 전처리기 지시자로 컴파일러로 하여금 화면 입출력을 위해 이 프로그램에 "
            + "iostream 라이브러리를 포함하도록 한다. C++ 라이브러리에는 C++ 프로그램 개발을 위해 미리 정의된 코드가 포함되어 있다. "
            + "iostream 같은 라이브러리는 C++에서 헤더 파일이라고 하는데, 보통 프로그램의 상단에 위치하기 때문이다." + "</color>";

            if (Code1Generator.instance.code1_5 != null)
            {
                Destroy(Code1Generator.instance.code1_5);
            }
            else
            { ;}
            if (this.s1_5 != null)
            {
                Destroy(this.s1_5);
            }
            else
            { ;}
            count++;
        }

        if (other.gameObject.tag == "s1_0" && Code1Generator.instance.array1[1] == 0 && count == 1)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle1.transform.position = new Vector3(23.2f, -3.03f);

            this.explain1.GetComponent<Text>().text = "";
            this.explain1.GetComponent<Text>().text = "<color=white>" + "using namespace std;는 컴파일러에게 표준 네임스페이스를 사용한다고 알려 주는 것이다. "
            + "std는 표준(standard)의 줄임말이다. 네임스페이스란 큰 프로그램에서 이름으로 인한 혼란을 피하기 위해 정의된 것이다. "
            + "6,7번 줄의 cout과 7번 줄의 endl이라는 이름은 표준 네임스페이스에서 iostream 라이브러리에 정의되어 있다. 컴파일러가 이들 이름을 찾도록 하기 위해서 using namespace std; "
            + "문장이 사용되어야 한다." + "</color>";

            if (Code1Generator.instance.code1_0 != null)
            {
                Destroy(Code1Generator.instance.code1_0);
            }
            else
            { ;}
            if (this.s1_0 != null)
            {
                Destroy(this.s1_0);
            }
            else
            { ;}
            count++;
        }
        else if (other.gameObject.tag == "s1_1" && Code1Generator.instance.array1[1] == 1 && count == 1)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle1.transform.position = new Vector3(23.2f, -3.03f);

            this.explain1.GetComponent<Text>().text = "";
            this.explain1.GetComponent<Text>().text = "<color=white>" + "using namespace std;는 컴파일러에게 표준 네임스페이스를 사용한다고 알려 주는 것이다. "
            + "std는 표준(standard)의 줄임말이다. 네임스페이스란 큰 프로그램에서 이름으로 인한 혼란을 피하기 위해 정의된 것이다. "
            + "6,7번 줄의 cout과 7번 줄의 endl이라는 이름은 표준 네임스페이스에서 iostream 라이브러리에 정의되어 있다. 컴파일러가 이들 이름을 찾도록 하기 위해서 using namespace std; "
            + "문장이 사용되어야 한다." + "</color>";
            if (Code1Generator.instance.code1_1 != null)
            {
                Destroy(Code1Generator.instance.code1_1);
            }
            else
            { ;}
            if (this.s1_1 != null)
            {
                Destroy(this.s1_1);
            }
            else
            { ;}
            count++;
        }
        else if (other.gameObject.tag == "s1_2" && Code1Generator.instance.array1[1] == 2 && count == 1)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle1.transform.position = new Vector3(23.2f, -3.03f);

            this.explain1.GetComponent<Text>().text = "";
            this.explain1.GetComponent<Text>().text = "<color=white>" + "using namespace std;는 컴파일러에게 표준 네임스페이스를 사용한다고 알려 주는 것이다. "
            + "std는 표준(standard)의 줄임말이다. 네임스페이스란 큰 프로그램에서 이름으로 인한 혼란을 피하기 위해 정의된 것이다. "
            + "6,7번 줄의 cout과 7번 줄의 endl이라는 이름은 표준 네임스페이스에서 iostream 라이브러리에 정의되어 있다. 컴파일러가 이들 이름을 찾도록 하기 위해서 using namespace std; "
            + "문장이 사용되어야 한다." + "</color>";

            if (Code1Generator.instance.code1_2 != null)
            {
                Destroy(Code1Generator.instance.code1_2);
            }
            else
            { ;}
            if (this.s1_2 != null)
            {
                Destroy(this.s1_2);
            }
            else
            { ;}
            count++;
        }
        else if (other.gameObject.tag == "s1_3" && Code1Generator.instance.array1[1] == 3 && count == 1)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle1.transform.position = new Vector3(23.2f, -3.03f);

            this.explain1.GetComponent<Text>().text = "";
            this.explain1.GetComponent<Text>().text = "<color=white>" + "using namespace std;는 컴파일러에게 표준 네임스페이스를 사용한다고 알려 주는 것이다. "
            + "std는 표준(standard)의 줄임말이다. 네임스페이스란 큰 프로그램에서 이름으로 인한 혼란을 피하기 위해 정의된 것이다. "
            + "6,7번 줄의 cout과 7번 줄의 endl이라는 이름은 표준 네임스페이스에서 iostream 라이브러리에 정의되어 있다. 컴파일러가 이들 이름을 찾도록 하기 위해서 using namespace std; "
            + "문장이 사용되어야 한다." + "</color>";

            if (Code1Generator.instance.code1_3 != null)
            {
                Destroy(Code1Generator.instance.code1_3);
            }
            else
            { ;}
            if (this.s1_3 != null)
            {
                Destroy(this.s1_3);
            }
            else
            { ;}
            count++;
        }
        else if (other.gameObject.tag == "s1_4" && Code1Generator.instance.array1[1] == 4 && count == 1)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle1.transform.position = new Vector3(23.2f, -3.03f);

            this.explain1.GetComponent<Text>().text = "";
            this.explain1.GetComponent<Text>().text = "<color=white>" + "using namespace std;는 컴파일러에게 표준 네임스페이스를 사용한다고 알려 주는 것이다. "
            + "std는 표준(standard)의 줄임말이다. 네임스페이스란 큰 프로그램에서 이름으로 인한 혼란을 피하기 위해 정의된 것이다. "
            + "6,7번 줄의 cout과 7번 줄의 endl이라는 이름은 표준 네임스페이스에서 iostream 라이브러리에 정의되어 있다. 컴파일러가 이들 이름을 찾도록 하기 위해서 using namespace std; "
            + "문장이 사용되어야 한다." + "</color>";

            if (Code1Generator.instance.code1_4 != null)
            {
                Destroy(Code1Generator.instance.code1_4);
            }
            else
            { ;}
            if (this.s1_4 != null)
            {
                Destroy(this.s1_4);
            }
            else
            { ;}
            count++;
        }
        else if (other.gameObject.tag == "s1_5" && Code1Generator.instance.array1[1] == 5 && count == 1)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle1.transform.position = new Vector3(23.2f, -3.03f);

            this.explain1.GetComponent<Text>().text = "";
            this.explain1.GetComponent<Text>().text = "<color=white>" + "using namespace std;는 컴파일러에게 표준 네임스페이스를 사용한다고 알려 주는 것이다. "
            + "std는 표준(standard)의 줄임말이다. 네임스페이스란 큰 프로그램에서 이름으로 인한 혼란을 피하기 위해 정의된 것이다. "
            + "6,7번 줄의 cout과 7번 줄의 endl이라는 이름은 표준 네임스페이스에서 iostream 라이브러리에 정의되어 있다. 컴파일러가 이들 이름을 찾도록 하기 위해서 using namespace std; "
            + "문장이 사용되어야 한다." + "</color>";

            if (Code1Generator.instance.code1_5 != null)
            {
                Destroy(Code1Generator.instance.code1_5);
            }
            else
            { ;}
            if (this.s1_5 != null)
            {
                Destroy(this.s1_5);
            }
            else
            { ;}
            count++;
        }


        if (other.gameObject.tag == "s1_0" && Code1Generator.instance.array1[2] == 0 && count == 2)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle1.transform.position = new Vector3(27.14f, -3.53f);

            this.explain1.GetComponent<Text>().text = "";
            this.explain1.GetComponent<Text>().text = "<color=white>" + "모든 C++ 프로그램은 main 함수로부터 실행되며, 하나의 함수는 문장으로 구성된다. "
            + "4~10번 줄에 작성된 main 함수에는 2개의 문장이 있다. 그러한 문장들은 블록안에 작성되는데, 문장은 {(5번 줄)로 시작되며} (10번 줄)로 끝이 난다. "
            + "C++에서 모든 문장은 문 종결자인 ;(세미콜론)으로 끝내야 한다." + "</color>";

            if (Code1Generator.instance.code1_0 != null)
            {
                Destroy(Code1Generator.instance.code1_0);
            }
            else
            { ;}
            if (this.s1_0 != null)
            {
                Destroy(this.s1_0);
            }
            else
            { ;}
            count++;
        }
        else if (other.gameObject.tag == "s1_1" && Code1Generator.instance.array1[2] == 1 && count == 2)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle1.transform.position = new Vector3(27.14f, -3.53f);

            this.explain1.GetComponent<Text>().text = "";
            this.explain1.GetComponent<Text>().text = "<color=white>" + "모든 C++ 프로그램은 main 함수로부터 실행되며, 하나의 함수는 문장으로 구성된다. "
            + "4~10번 줄에 작성된 main 함수에는 2개의 문장이 있다. 그러한 문장들은 블록안에 작성되는데, 문장은 {(5번 줄)로 시작되며} (10번 줄)로 끝이 난다. "
            + "C++에서 모든 문장은 문 종결자인 ;(세미콜론)으로 끝내야 한다." + "</color>";

            if (Code1Generator.instance.code1_1 != null)
            {
                Destroy(Code1Generator.instance.code1_1);
            }
            else
            { ;}
            if (this.s1_1 != null)
            {
                Destroy(this.s1_1);
            }
            else
            { ;}
            count++;
        }
        else if (other.gameObject.tag == "s1_2" && Code1Generator.instance.array1[2] == 2 && count == 2)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle1.transform.position = new Vector3(27.14f, -3.53f);

            this.explain1.GetComponent<Text>().text = "";
            this.explain1.GetComponent<Text>().text = "<color=white>" + "모든 C++ 프로그램은 main 함수로부터 실행되며, 하나의 함수는 문장으로 구성된다. "
            + "4~10번 줄에 작성된 main 함수에는 2개의 문장이 있다. 그러한 문장들은 블록안에 작성되는데, 문장은 {(5번 줄)로 시작되며} (10번 줄)로 끝이 난다. "
            + "C++에서 모든 문장은 문 종결자인 ;(세미콜론)으로 끝내야 한다." + "</color>";

            if (Code1Generator.instance.code1_2 != null)
            {
                Destroy(Code1Generator.instance.code1_2);
            }
            else
            { ;}
            if (this.s1_2 != null)
            {
                Destroy(this.s1_2);
            }
            else
            { ;}
            count++;
        }
        else if (other.gameObject.tag == "s1_3" && Code1Generator.instance.array1[2] == 3 && count == 2)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle1.transform.position = new Vector3(27.14f, -3.53f);

            this.explain1.GetComponent<Text>().text = "";
            this.explain1.GetComponent<Text>().text = "<color=white>" + "모든 C++ 프로그램은 main 함수로부터 실행되며, 하나의 함수는 문장으로 구성된다. "
            + "4~10번 줄에 작성된 main 함수에는 2개의 문장이 있다. 그러한 문장들은 블록안에 작성되는데, 문장은 {(5번 줄)로 시작되며} (10번 줄)로 끝이 난다. "
            + "C++에서 모든 문장은 문 종결자인 ;(세미콜론)으로 끝내야 한다." + "</color>";

            if (Code1Generator.instance.code1_3 != null)
            {
                Destroy(Code1Generator.instance.code1_3);
            }
            else
            { ;}
            if (this.s1_3 != null)
            {
                Destroy(this.s1_3);
            }
            else
            { ;}
            count++;
        }
        else if (other.gameObject.tag == "s1_4" && Code1Generator.instance.array1[2] == 4 && count == 2)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle1.transform.position = new Vector3(27.14f, -3.53f);

            this.explain1.GetComponent<Text>().text = "";
            this.explain1.GetComponent<Text>().text = "<color=white>" + "모든 C++ 프로그램은 main 함수로부터 실행되며, 하나의 함수는 문장으로 구성된다. "
            + "4~10번 줄에 작성된 main 함수에는 2개의 문장이 있다. 그러한 문장들은 블록안에 작성되는데, 문장은 {(5번 줄)로 시작되며} (10번 줄)로 끝이 난다. "
            + "C++에서 모든 문장은 문 종결자인 ;(세미콜론)으로 끝내야 한다." + "</color>";

            if (Code1Generator.instance.code1_4 != null)
            {
                Destroy(Code1Generator.instance.code1_4);
            }
            else
            { ;}
            if (this.s1_4 != null)
            {
                Destroy(this.s1_4);
            }
            else
            { ;}
            count++;
        }
        else if (other.gameObject.tag == "s1_5" && Code1Generator.instance.array1[2] == 5 && count == 2)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle1.transform.position = new Vector3(27.14f, -3.53f);

            this.explain1.GetComponent<Text>().text = "";
            this.explain1.GetComponent<Text>().text = "<color=white>" + "모든 C++ 프로그램은 main 함수로부터 실행되며, 하나의 함수는 문장으로 구성된다. "
            + "4~10번 줄에 작성된 main 함수에는 2개의 문장이 있다. 그러한 문장들은 블록안에 작성되는데, 문장은 {(5번 줄)로 시작되며} (10번 줄)로 끝이 난다. "
            + "C++에서 모든 문장은 문 종결자인 ;(세미콜론)으로 끝내야 한다." + "</color>";

            if (Code1Generator.instance.code1_5 != null)
            {
                Destroy(Code1Generator.instance.code1_5);
            }
            else
            { ;}
            if (this.s1_5 != null)
            {
                Destroy(this.s1_5);
            }
            else
            { ;}
            count++;
        }

        if (other.gameObject.tag == "s1_0" && Code1Generator.instance.array1[3] == 0 && count == 3)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle1.transform.position = new Vector3(27.43f, -3.8f);

            this.explain1.GetComponent<Text>().text = "";
            this.explain1.GetComponent<Text>().text = "<color=white>" + "cout은 콘솔 출력을 의미하므로 (10.5 + 2 * 3) / (45 - 3.5) = 을 화면에 출력한다." + "</color>";

            if (Code1Generator.instance.code1_0 != null)
            {
                Destroy(Code1Generator.instance.code1_0);
            }
            else
            { ;}
            if (this.s1_0 != null)
            {
                Destroy(this.s1_0);
            }
            else
            { ;}
            count++;
        }
        else if (other.gameObject.tag == "s1_1" && Code1Generator.instance.array1[3] == 1 && count == 3)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle1.transform.position = new Vector3(27.43f, -3.8f);

            this.explain1.GetComponent<Text>().text = "";
            this.explain1.GetComponent<Text>().text = "<color=white>" + "cout은 콘솔 출력을 의미하므로 (10.5 + 2 * 3) / (45 - 3.5) = 을 화면에 출력한다." + "</color>";

            if (Code1Generator.instance.code1_1 != null)
            {
                Destroy(Code1Generator.instance.code1_1);
            }
            else
            { ;}
            if (this.s1_1 != null)
            {
                Destroy(this.s1_1);
            }
            else
            { ;}
            count++;
        }
        else if (other.gameObject.tag == "s1_2" && Code1Generator.instance.array1[3] == 2 && count == 3)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle1.transform.position = new Vector3(27.43f, -3.8f);

            this.explain1.GetComponent<Text>().text = "";
            this.explain1.GetComponent<Text>().text = "<color=white>" + "cout은 콘솔 출력을 의미하므로 (10.5 + 2 * 3) / (45 - 3.5) = 을 화면에 출력한다." + "</color>";

            if (Code1Generator.instance.code1_2 != null)
            {
                Destroy(Code1Generator.instance.code1_2);
            }
            else
            { ;}
            if (this.s1_2 != null)
            {
                Destroy(this.s1_2);
            }
            else
            { ;}
            count++;
        }
        else if (other.gameObject.tag == "s1_3" && Code1Generator.instance.array1[3] == 3 && count == 3)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle1.transform.position = new Vector3(27.43f, -3.8f);

            this.explain1.GetComponent<Text>().text = "";
            this.explain1.GetComponent<Text>().text = "<color=white>" + "cout은 콘솔 출력을 의미하므로 (10.5 + 2 * 3) / (45 - 3.5) = 을 화면에 출력한다." + "</color>";

            if (Code1Generator.instance.code1_3 != null)
            {
                Destroy(Code1Generator.instance.code1_3);
            }
            else
            { ;}
            if (this.s1_3 != null)
            {
                Destroy(this.s1_3);
            }
            else
            { ;}
            count++;
        }
        else if (other.gameObject.tag == "s1_4" && Code1Generator.instance.array1[3] == 4 && count == 3)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle1.transform.position = new Vector3(27.43f, -3.8f);

            this.explain1.GetComponent<Text>().text = "";
            this.explain1.GetComponent<Text>().text = "<color=white>" + "cout은 콘솔 출력을 의미하므로 (10.5 + 2 * 3) / (45 - 3.5) = 을 화면에 출력한다." + "</color>";

            if (Code1Generator.instance.code1_4 != null)
            {
                Destroy(Code1Generator.instance.code1_4);
            }
            else
            { ;}
            if (this.s1_4 != null)
            {
                Destroy(this.s1_4);
            }
            else
            { ;}
            count++;
        }
        else if (other.gameObject.tag == "s1_5" && Code1Generator.instance.array1[3] == 5 && count == 3)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle1.transform.position = new Vector3(27.43f, -3.8f);

            this.explain1.GetComponent<Text>().text = "";
            this.explain1.GetComponent<Text>().text = "<color=white>" + "cout은 콘솔 출력을 의미하므로 (10.5 + 2 * 3) / (45 - 3.5) = 을 화면에 출력한다." + "</color>";

            if (Code1Generator.instance.code1_5 != null)
            {
                Destroy(Code1Generator.instance.code1_5);
            }
            else
            { ;}
            if (this.s1_5 != null)
            {
                Destroy(this.s1_5);
            }
            else
            { ;}
            count++;
        }

        if (other.gameObject.tag == "s1_0" && Code1Generator.instance.array1[4] == 0 && count == 4)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle1.transform.position = new Vector3(23.54f, -4.32f);

            this.explain1.GetComponent<Text>().text = "";
            this.explain1.GetComponent<Text>().text = "<color=white>" + "C++에서 곱하기 기호는 *이다. 산술식을 C++ 문장으로 바로 변환할 수 있다. (10.5 + 2 * 3) / (45 - 3.5)"
                + "를 연산하여 콘솔에 출력한다." + "</color>";

            if (Code1Generator.instance.code1_0 != null)
            {
                Destroy(Code1Generator.instance.code1_0);
            }
            else
            { ;}
            if (this.s1_0 != null)
            {
                Destroy(this.s1_0);
            }
            else
            { ;}
            count++;
        }
        else if (other.gameObject.tag == "s1_1" && Code1Generator.instance.array1[4] == 1 && count == 4)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle1.transform.position = new Vector3(23.54f, -4.32f);

            this.explain1.GetComponent<Text>().text = "";
            this.explain1.GetComponent<Text>().text = "<color=white>" + "C++에서 곱하기 기호는 *이다. 산술식을 C++ 문장으로 바로 변환할 수 있다. (10.5 + 2 * 3) / (45 - 3.5)"
                + "를 연산하여 콘솔에 출력한다." + "</color>";

            if (Code1Generator.instance.code1_1 != null)
            {
                Destroy(Code1Generator.instance.code1_1);
            }
            else
            { ;}
            if (this.s1_1 != null)
            {
                Destroy(this.s1_1);
            }
            else
            { ;}
            count++;
        }
        else if (other.gameObject.tag == "s1_2" && Code1Generator.instance.array1[4] == 2 && count == 4)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle1.transform.position = new Vector3(23.54f, -4.32f);

            this.explain1.GetComponent<Text>().text = "";
            this.explain1.GetComponent<Text>().text = "<color=white>" + "C++에서 곱하기 기호는 *이다. 산술식을 C++ 문장으로 바로 변환할 수 있다. (10.5 + 2 * 3) / (45 - 3.5)"
                + "를 연산하여 콘솔에 출력한다." + "</color>";

            if (Code1Generator.instance.code1_2 != null)
            {
                Destroy(Code1Generator.instance.code1_2);
            }
            else
            { ;}
            if (this.s1_2 != null)
            {
                Destroy(this.s1_2);
            }
            else
            { ;}
            count++;
        }
        else if (other.gameObject.tag == "s1_3" && Code1Generator.instance.array1[4] == 3 && count == 4)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle1.transform.position = new Vector3(23.54f, -4.32f);

            this.explain1.GetComponent<Text>().text = "";
            this.explain1.GetComponent<Text>().text = "<color=white>" + "C++에서 곱하기 기호는 *이다. 산술식을 C++ 문장으로 바로 변환할 수 있다. (10.5 + 2 * 3) / (45 - 3.5)"
                + "를 연산하여 콘솔에 출력한다." + "</color>";

            if (Code1Generator.instance.code1_3 != null)
            {
                Destroy(Code1Generator.instance.code1_3);
            }
            else
            { ;}
            if (this.s1_3 != null)
            {
                Destroy(this.s1_3);
            }
            else
            { ;}
            count++;
        }
        else if (other.gameObject.tag == "s1_4" && Code1Generator.instance.array1[4] == 4 && count == 4)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle1.transform.position = new Vector3(23.54f, -4.32f);

            this.explain1.GetComponent<Text>().text = "";
            this.explain1.GetComponent<Text>().text = "<color=white>" + "C++에서 곱하기 기호는 *이다. 산술식을 C++ 문장으로 바로 변환할 수 있다. (10.5 + 2 * 3) / (45 - 3.5)"
                + "를 연산하여 콘솔에 출력한다." + "</color>";

            if (Code1Generator.instance.code1_4 != null)
            {
                Destroy(Code1Generator.instance.code1_4);
            }
            else
            { ;}
            if (this.s1_4 != null)
            {
                Destroy(this.s1_4);
            }
            else
            { ;}
            count++;
        }
        else if (other.gameObject.tag == "s1_5" && Code1Generator.instance.array1[4] == 5 && count == 4)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle1.transform.position = new Vector3(23.54f, -4.32f);

            this.explain1.GetComponent<Text>().text = "";
            this.explain1.GetComponent<Text>().text = "<color=white>" + "C++에서 곱하기 기호는 *이다. 산술식을 C++ 문장으로 바로 변환할 수 있다. (10.5 + 2 * 3) / (45 - 3.5)"
                + "를 연산하여 콘솔에 출력한다." + "</color>";

            if (Code1Generator.instance.code1_5 != null)
            {
                Destroy(Code1Generator.instance.code1_5);
            }
            else
            { ;}
            if (this.s1_5 != null)
            {
                Destroy(this.s1_5);
            }
            else
            { ;}
            count++;
        }

        if (other.gameObject.tag == "s1_0" && Code1Generator.instance.array1[5] == 0 && count == 5)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();
            this.transform.position = new Vector3(31.55f, -3.42f, 0);
            this.talk.transform.position = new Vector3(31.71f, -3.26f, 0);
            this.Talk1.GetComponent<Text>().text = "<color=white>" + "다음 코드를 알고 싶으면 스페이스바를 눌러봐!" + "</color>";
            isAlive = false;

            this.explain1.GetComponent<Text>().text = "";
            this.explain1.GetComponent<Text>().text = "<color=white>" + "return 0;은 프로그램의 맨 마지막에 작성되어 있으며 프로그램이 종료되는 것을 의미한다. "
            + "값이 0인 것은 프로그램이 정상적인 종료가 되었음을 의미하는 것이다. 이 문장은 생략할 경우 컴파일러에 따라 프로그램이 잘 동작하거나 아니면 오류를 발생시킬 수 있다. "
            + "그러므로 모든 C++ 컴파일러에서 작성 중인 프로그램이 잘 동작하게 하려면 이 문장을 항상 포함시키는 것이 좋다." + "</color>";

            SupermanController.instance.code1Count = 2;

            if (Code1Generator.instance.code1_0 != null)
            {
                Destroy(Code1Generator.instance.code1_0);
            }
            else
            { ;}
            if (this.s1_0 != null)
            {
                Destroy(this.s1_0);
            }
            else
            { ;}
            count++;
        }
        else if (other.gameObject.tag == "s1_1" && Code1Generator.instance.array1[5] == 1 && count == 5)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();
            this.transform.position = new Vector3(31.55f, -3.42f, 0);
            this.talk.transform.position = new Vector3(31.71f, -3.26f, 0);
            this.Talk1.GetComponent<Text>().text = "<color=white>" + "다음 코드를 알고 싶으면 스페이스바를 눌러봐!" + "</color>";
            isAlive = false;

            this.explain1.GetComponent<Text>().text = "";
            this.explain1.GetComponent<Text>().text = "<color=white>" + "return 0;은 프로그램의 맨 마지막에 작성되어 있으며 프로그램이 종료되는 것을 의미한다. "
            + "값이 0인 것은 프로그램이 정상적인 종료가 되었음을 의미하는 것이다. 이 문장은 생략할 경우 컴파일러에 따라 프로그램이 잘 동작하거나 아니면 오류를 발생시킬 수 있다. "
            + "그러므로 모든 C++ 컴파일러에서 작성 중인 프로그램이 잘 동작하게 하려면 이 문장을 항상 포함시키는 것이 좋다." + "</color>";

            SupermanController.instance.code1Count = 2;

            if (Code1Generator.instance.code1_1 != null)
            {
                Destroy(Code1Generator.instance.code1_1);
            }
            else
            { ;}
            if (this.s1_1 != null)
            {
                Destroy(this.s1_1);
            }
            else
            { ;}
            count++;
        }
        else if (other.gameObject.tag == "s1_2" && Code1Generator.instance.array1[5] == 2 && count == 5)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();
            this.transform.position = new Vector3(31.55f, -3.42f, 0);
            this.talk.transform.position = new Vector3(31.71f, -3.26f, 0);
            this.Talk1.GetComponent<Text>().text = "<color=white>" + "다음 코드를 알고 싶으면 스페이스바를 눌러봐!" + "</color>";
            isAlive = false;

            this.explain1.GetComponent<Text>().text = "";
            this.explain1.GetComponent<Text>().text = "<color=white>" + "return 0;은 프로그램의 맨 마지막에 작성되어 있으며 프로그램이 종료되는 것을 의미한다. "
            + "값이 0인 것은 프로그램이 정상적인 종료가 되었음을 의미하는 것이다. 이 문장은 생략할 경우 컴파일러에 따라 프로그램이 잘 동작하거나 아니면 오류를 발생시킬 수 있다. "
            + "그러므로 모든 C++ 컴파일러에서 작성 중인 프로그램이 잘 동작하게 하려면 이 문장을 항상 포함시키는 것이 좋다." + "</color>";

            SupermanController.instance.code1Count = 2;

            if (Code1Generator.instance.code1_2 != null)
            {
                Destroy(Code1Generator.instance.code1_2);
            }
            else
            { ;}
            if (this.s1_2 != null)
            {
                Destroy(this.s1_2);
            }
            else
            { ;}
            count++;
        }
        else if (other.gameObject.tag == "s1_3" && Code1Generator.instance.array1[5] == 3 && count == 5)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();
            this.transform.position = new Vector3(31.55f, -3.42f, 0);
            this.talk.transform.position = new Vector3(31.71f, -3.26f, 0);
            this.Talk1.GetComponent<Text>().text = "<color=white>" + "다음 코드를 알고 싶으면 스페이스바를 눌러봐!" + "</color>";
            isAlive = false;

            this.explain1.GetComponent<Text>().text = "";
            this.explain1.GetComponent<Text>().text = "<color=white>" + "return 0;은 프로그램의 맨 마지막에 작성되어 있으며 프로그램이 종료되는 것을 의미한다. "
            + "값이 0인 것은 프로그램이 정상적인 종료가 되었음을 의미하는 것이다. 이 문장은 생략할 경우 컴파일러에 따라 프로그램이 잘 동작하거나 아니면 오류를 발생시킬 수 있다. "
            + "그러므로 모든 C++ 컴파일러에서 작성 중인 프로그램이 잘 동작하게 하려면 이 문장을 항상 포함시키는 것이 좋다." + "</color>";

            SupermanController.instance.code1Count = 2;

            if (Code1Generator.instance.code1_3 != null)
            {
                Destroy(Code1Generator.instance.code1_3);
            }
            else
            { ;}
            if (this.s1_3 != null)
            {
                Destroy(this.s1_3);
            }
            else
            { ;}
            count++;
        }
        else if (other.gameObject.tag == "s1_4" && Code1Generator.instance.array1[5] == 4 && count == 5)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();
            this.transform.position = new Vector3(31.55f, -3.42f, 0);
            this.talk.transform.position = new Vector3(31.71f, -3.26f, 0);
            this.Talk1.GetComponent<Text>().text = "<color=white>" + "다음 코드를 알고 싶으면 스페이스바를 눌러봐!" + "</color>";
            isAlive = false;

            this.explain1.GetComponent<Text>().text = "";
            this.explain1.GetComponent<Text>().text = "<color=white>" + "return 0;은 프로그램의 맨 마지막에 작성되어 있으며 프로그램이 종료되는 것을 의미한다. "
            + "값이 0인 것은 프로그램이 정상적인 종료가 되었음을 의미하는 것이다. 이 문장은 생략할 경우 컴파일러에 따라 프로그램이 잘 동작하거나 아니면 오류를 발생시킬 수 있다. "
            + "그러므로 모든 C++ 컴파일러에서 작성 중인 프로그램이 잘 동작하게 하려면 이 문장을 항상 포함시키는 것이 좋다." + "</color>";

            SupermanController.instance.code1Count = 2;

            if (Code1Generator.instance.code1_4 != null)
            {
                Destroy(Code1Generator.instance.code1_4);
            }
            else
            { ;}
            if (this.s1_4 != null)
            {
                Destroy(this.s1_4);
            }
            else
            { ;}
            count++;
        }
        else if (other.gameObject.tag == "s1_5" && Code1Generator.instance.array1[5] == 5 && count == 5)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();
            this.transform.position = new Vector3(31.55f, -3.42f, 0);
            this.talk.transform.position = new Vector3(31.71f, -3.26f, 0);
            this.Talk1.GetComponent<Text>().text = "<color=white>" + "다음 코드를 알고 싶으면 스페이스바를 눌러봐!" + "</color>";
            isAlive = false;

            this.explain1.GetComponent<Text>().text = "";
            this.explain1.GetComponent<Text>().text = "<color=white>" + "return 0;은 프로그램의 맨 마지막에 작성되어 있으며 프로그램이 종료되는 것을 의미한다. "
            + "값이 0인 것은 프로그램이 정상적인 종료가 되었음을 의미하는 것이다. 이 문장은 생략할 경우 컴파일러에 따라 프로그램이 잘 동작하거나 아니면 오류를 발생시킬 수 있다. "
            + "그러므로 모든 C++ 컴파일러에서 작성 중인 프로그램이 잘 동작하게 하려면 이 문장을 항상 포함시키는 것이 좋다." + "</color>";

            SupermanController.instance.code1Count = 2;

            if (Code1Generator.instance.code1_5 != null)
            {
                Destroy(Code1Generator.instance.code1_5);
            }
            else
            { ;}
            if (this.s1_5 != null)
            {
                Destroy(this.s1_5);
            }
            else
            { ;}
            count++;
        }
    }


    void Start()
    {
        count = 0;

        this.s1_0 = GameObject.Find("s1_0");
        this.s1_1 = GameObject.Find("s1_1");
        this.s1_2 = GameObject.Find("s1_2");
        this.s1_3 = GameObject.Find("s1_3");
        this.s1_4 = GameObject.Find("s1_4");
        this.s1_5 = GameObject.Find("s1_5");
        this.explain1 = GameObject.Find("explain1");
        this.particle = GameObject.Find("Particle System");
        this.circle1 = GameObject.Find("circle1");
        this.talk = GameObject.Find("talk");
        this.Talk1 = GameObject.Find("Talk");
        this.cam = GameObject.Find("Main Camera");
    }

    void Update()
    {

        if (SupermanController.instance.code1Count == 1 && isAlive == true)
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Translate(moveSpeed * Time.deltaTime, 0, 0);
                this.transform.localScale = new Vector3(1, 1, 1);
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Translate(-moveSpeed * Time.deltaTime, 0, 0);
                this.transform.localScale = new Vector3(-1, 1, 1);
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

        if (SupermanController.instance.code1Count == 2)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                code2Count = 1;
                this.cam.transform.position = new Vector3(60, 0, -10);
                this.Talk1.GetComponent<Text>().text = "";
                this.explain1.GetComponent<Text>().text = "";
                Destroy(gameObject);
            }
        }
        if (this.transform.position.x >= 39.7f || this.transform.position.x <= 20.3f)
        {
            this.transform.position = new Vector3(31.55f, -3.42f, 0);
        }
        else if (this.transform.position.y >= 5.0f || this.transform.position.y <= -7.0f)
        {
            this.transform.position = new Vector3(31.55f, -3.42f, 0);
        }
    }
}
