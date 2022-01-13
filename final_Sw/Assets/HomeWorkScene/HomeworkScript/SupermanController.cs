using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SupermanController : MonoBehaviour
{
    public static SupermanController instance = null;

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

    int count, count1;
    public int code1Count;

    GameObject s0_0;
    GameObject s0_1;
    GameObject s0_2;
    GameObject s0_3;
    GameObject s0_4;
    GameObject explain;
    GameObject particle;
    GameObject circle;
    GameObject talk;
    GameObject Talk;
    GameObject cam;

    float delta = 0;
    float span = 7.0f;
    float moveSpeed = 4.0f;

    bool isAlive = false;
    bool isAlive1 = false;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "s0_0" && CodeGenerator.instance.array0[0] == 0 && count == 0)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle.transform.position = new Vector3(-5.63f, -2.52f, 1);

            this.explain.GetComponent<Text>().text = "<color=white>" + "#include <iostream>은 컴파일러 전처리기 지시자로 컴파일러로 하여금 화면 입출력을 위해 이 프로그램에 "
            + "iostream 라이브러리를 포함하도록 한다. C++ 라이브러리에는 C++ 프로그램 개발을 위해 미리 정의된 코드가 포함되어 있다. "
            + "iostream 같은 라이브러리는 C++에서 헤더 파일이라고 하는데, 보통 프로그램의 상단에 위치하기 때문이다." + "</color>";

            if (CodeGenerator.instance.code0_0 != null)
            {
                Destroy(CodeGenerator.instance.code0_0);
            }
            else
            { ;}
            if (this.s0_0 != null)
            {
                Destroy(this.s0_0);
            }
            else
            { ;}
            count++;
        }
        else if (other.gameObject.tag == "s0_1" && CodeGenerator.instance.array0[0] == 1 && count == 0)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle.transform.position = new Vector3(-5.63f, -2.52f, 1);

            this.explain.GetComponent<Text>().text = "<color=white>" + "#include <iostream>은 컴파일러 전처리기 지시자로 컴파일러로 하여금 화면 입출력을 위해 이 프로그램에 "
            + "iostream 라이브러리를 포함하도록 한다. C++ 라이브러리에는 C++ 프로그램 개발을 위해 미리 정의된 코드가 포함되어 있다. "
            + "iostream 같은 라이브러리는 C++에서 헤더 파일이라고 하는데, 보통 프로그램의 상단에 위치하기 때문이다." + "</color>";

            if (CodeGenerator.instance.code0_1 != null)
            {
                Destroy(CodeGenerator.instance.code0_1);
            }
            if (this.s0_1 != null)
            {
                Destroy(this.s0_1);
            }
            count++;
        }
        else if (other.gameObject.tag == "s0_2" && CodeGenerator.instance.array0[0] == 2 && count == 0)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle.transform.position = new Vector3(-5.63f, -2.52f, 1);

            this.explain.GetComponent<Text>().text = "<color=white>" + "#include <iostream>은 컴파일러 전처리기 지시자로 컴파일러로 하여금 화면 입출력을 위해 이 프로그램에 "
            + "iostream 라이브러리를 포함하도록 한다. C++ 라이브러리에는 C++ 프로그램 개발을 위해 미리 정의된 코드가 포함되어 있다. "
            + "iostream 같은 라이브러리는 C++에서 헤더 파일이라고 하는데, 보통 프로그램의 상단에 위치하기 때문이다." + "</color>";

            if (CodeGenerator.instance.code0_2 != null)
            {
                Destroy(CodeGenerator.instance.code0_2);
            }
            else
            { ;}
            if (this.s0_2 != null)
            {
                Destroy(this.s0_2);
            }
            else
            { ;}
            count++;
        }
        else if (other.gameObject.tag == "s0_3" && CodeGenerator.instance.array0[0] == 3 && count == 0)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle.transform.position = new Vector3(-5.63f, -2.52f, 1);

            this.explain.GetComponent<Text>().text = "<color=white>" + "#include <iostream>은 컴파일러 전처리기 지시자로 컴파일러로 하여금 화면 입출력을 위해 이 프로그램에 "
            + "iostream 라이브러리를 포함하도록 한다. C++ 라이브러리에는 C++ 프로그램 개발을 위해 미리 정의된 코드가 포함되어 있다. "
            + "iostream 같은 라이브러리는 C++에서 헤더 파일이라고 하는데, 보통 프로그램의 상단에 위치하기 때문이다." + "</color>";

            if (CodeGenerator.instance.code0_3 != null)
            {
                Destroy(CodeGenerator.instance.code0_3);
            }
            else
            { ;}
            if (this.s0_3 != null)
            {
                Destroy(this.s0_3);
            }
            else
            { ;}
            count++;
        }
        else if (other.gameObject.tag == "s0_4" && CodeGenerator.instance.array0[0] == 4 && count == 0)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle.transform.position = new Vector3(-5.63f, -2.52f, 1);

            this.explain.GetComponent<Text>().text = "<color=white>" + "#include <iostream>은 컴파일러 전처리기 지시자로 컴파일러로 하여금 화면 입출력을 위해 이 프로그램에 "
            + "iostream 라이브러리를 포함하도록 한다. C++ 라이브러리에는 C++ 프로그램 개발을 위해 미리 정의된 코드가 포함되어 있다. "
            + "iostream 같은 라이브러리는 C++에서 헤더 파일이라고 하는데, 보통 프로그램의 상단에 위치하기 때문이다." + "</color>";

            if (CodeGenerator.instance.code0_4 != null)
            {
                Destroy(CodeGenerator.instance.code0_4);
            }
            else
            { ;}
            if (this.s0_4 != null)
            {
                Destroy(this.s0_4);
            }
            else
            { ;}
            count++;
        }

        if (other.gameObject.tag == "s0_0" && CodeGenerator.instance.array0[1] == 0 && count == 1)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1); 
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle.transform.position = new Vector3(-6.77f, -3.03f, 1);

            this.explain.GetComponent<Text>().text = "";
            this.explain.GetComponent<Text>().text = "<color=white>" + "using namespace std;는 컴파일러에게 표준 네임스페이스를 사용한다고 알려 주는 것이다. "
            + "std는 표준(standard)의 줄임말이다. 네임스페이스란 큰 프로그램에서 이름으로 인한 혼란을 피하기 위해 정의된 것이다. "
            + "6번 줄의 cout과 endl이라는 이름은 표준 네임스페이스에서 iostream 라이브러리에 정의되어 있다. 컴파일러가 이들 이름을 찾도록 하기 위해서 using namespace std; "
            + "문장이 사용되어야 한다." + "</color>";

            if (CodeGenerator.instance.code0_0 != null)
            {
                Destroy(CodeGenerator.instance.code0_0);
            }
            else
            { ;}
            if (this.s0_0 != null)
            {
                Destroy(this.s0_0);
            }
            else
            { ;}
            count++;
        }
        else if (other.gameObject.tag == "s0_1" && CodeGenerator.instance.array0[1] == 1 && count == 1)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle.transform.position = new Vector3(-6.77f, -3.03f, 1);

            this.explain.GetComponent<Text>().text = "";
            this.explain.GetComponent<Text>().text = "<color=white>" + "using namespace std;는 컴파일러에게 표준 네임스페이스를 사용한다고 알려 주는 것이다. "
            + "std는 표준(standard)의 줄임말이다. 네임스페이스란 큰 프로그램에서 이름으로 인한 혼란을 피하기 위해 정의된 것이다. "
            + "6번 줄의 cout과 endl이라는 이름은 표준 네임스페이스에서 iostream 라이브러리에 정의되어 있다. 컴파일러가 이들 이름을 찾도록 하기 위해서 using namespace std; "
            + "문장이 사용되어야 한다." + "</color>";

            if (CodeGenerator.instance.code0_1 != null)
            {
                Destroy(CodeGenerator.instance.code0_1);
            }
            else
            { ;}
            if (this.s0_1 != null)
            {
                Destroy(this.s0_1);
            }
            else
            { ;}
            count++;
        }
        else if (other.gameObject.tag == "s0_2" && CodeGenerator.instance.array0[1] == 2 && count == 1)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle.transform.position = new Vector3(-6.77f, -3.03f, 1);

            this.explain.GetComponent<Text>().text = "";
            this.explain.GetComponent<Text>().text = "<color=white>" + "using namespace std;는 컴파일러에게 표준 네임스페이스를 사용한다고 알려 주는 것이다. "
            + "std는 표준(standard)의 줄임말이다. 네임스페이스란 큰 프로그램에서 이름으로 인한 혼란을 피하기 위해 정의된 것이다. "
            + "6번 줄의 cout과 endl이라는 이름은 표준 네임스페이스에서 iostream 라이브러리에 정의되어 있다. 컴파일러가 이들 이름을 찾도록 하기 위해서 using namespace std; "
            + "문장이 사용되어야 한다." + "</color>";

            if (CodeGenerator.instance.code0_2 != null)
            {
                Destroy(CodeGenerator.instance.code0_2);
            }
            else
            { ;}
            if (this.s0_2 != null)
            {
                Destroy(this.s0_2);
            }
            else
            { ;}
            count++;
        }
        else if (other.gameObject.tag == "s0_3" && CodeGenerator.instance.array0[1] == 3 && count == 1)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle.transform.position = new Vector3(-6.77f, -3.03f, 1);

            this.explain.GetComponent<Text>().text = "";
            this.explain.GetComponent<Text>().text = "<color=white>" + "using namespace std;는 컴파일러에게 표준 네임스페이스를 사용한다고 알려 주는 것이다. "
            + "std는 표준(standard)의 줄임말이다. 네임스페이스란 큰 프로그램에서 이름으로 인한 혼란을 피하기 위해 정의된 것이다. "
            + "6번 줄의 cout과 endl이라는 이름은 표준 네임스페이스에서 iostream 라이브러리에 정의되어 있다. 컴파일러가 이들 이름을 찾도록 하기 위해서 using namespace std; "
            + "문장이 사용되어야 한다." + "</color>";

            if (CodeGenerator.instance.code0_3 != null)
            {
                Destroy(CodeGenerator.instance.code0_3);
            }
            else
            { ;}
            if (this.s0_3 != null)
            {
                Destroy(this.s0_3);
            }
            else
            { ;}
            count++;
        }
        else if (other.gameObject.tag == "s0_4" && CodeGenerator.instance.array0[1] == 4 && count == 1)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle.transform.position = new Vector3(-6.77f, -3.03f, 1);

            this.explain.GetComponent<Text>().text = "";
            this.explain.GetComponent<Text>().text = "<color=white>" + "using namespace std;는 컴파일러에게 표준 네임스페이스를 사용한다고 알려 주는 것이다. "
            + "std는 표준(standard)의 줄임말이다. 네임스페이스란 큰 프로그램에서 이름으로 인한 혼란을 피하기 위해 정의된 것이다. "
            + "6번 줄의 cout과 endl이라는 이름은 표준 네임스페이스에서 iostream 라이브러리에 정의되어 있다. 컴파일러가 이들 이름을 찾도록 하기 위해서 using namespace std; "
            + "문장이 사용되어야 한다." + "</color>";

            if (CodeGenerator.instance.code0_4 != null)
            {
                Destroy(CodeGenerator.instance.code0_4);
            }
            else
            { ;}
            if (this.s0_4 != null)
            {
                Destroy(this.s0_4);
            }
            else
            { ;}
            count++;
        }

        if (other.gameObject.tag == "s0_0" && CodeGenerator.instance.array0[2] == 0 && count == 2)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle.transform.position = new Vector3(-3.61f, -3.54f, 1);

            this.explain.GetComponent<Text>().text = "";
            this.explain.GetComponent<Text>().text = "<color=white>" + "모든 C++ 프로그램은 main 함수로부터 실행되며, 하나의 함수는 문장으로 구성된다. "
            + "4~9번 줄에 작성된 main 함수에는 2개의 문장이 있다. 그러한 문장들은 블록안에 작성되는데, 문장은 {(5번 줄)로 시작되며} (9번 줄)로 끝이 난다. "
            + "C++에서 모든 문장은 문 종결자인 ;(세미콜론)으로 끝내야 한다." + "</color>";

            if (CodeGenerator.instance.code0_0 != null)
            {
                Destroy(CodeGenerator.instance.code0_0);
            }
            else
            { ;}
            if (this.s0_0 != null)
            {
                Destroy(this.s0_0);
            }
            else
            { ;}
            count++;
        }
        else if (other.gameObject.tag == "s0_1" && CodeGenerator.instance.array0[2] == 1 && count == 2)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle.transform.position = new Vector3(-3.61f, -3.54f, 1);

            this.explain.GetComponent<Text>().text = "";
            this.explain.GetComponent<Text>().text = "<color=white>" + "모든 C++ 프로그램은 main 함수로부터 실행되며, 하나의 함수는 문장으로 구성된다. "
            + "4~9번 줄에 작성된 main 함수에는 2개의 문장이 있다. 그러한 문장들은 블록안에 작성되는데, 문장은 {(5번 줄)로 시작되며} (9번 줄)로 끝이 난다. "
            + "C++에서 모든 문장은 문 종결자인 ;(세미콜론)으로 끝내야 한다." + "</color>";

            if (CodeGenerator.instance.code0_1 != null)
            {
                Destroy(CodeGenerator.instance.code0_1);
            }
            else
            { ;}
            if (this.s0_1 != null)
            {
                Destroy(this.s0_1);
            }
            else
            { ;}
            count++;
        }
        else if (other.gameObject.tag == "s0_2" && CodeGenerator.instance.array0[2] == 2 && count == 2)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle.transform.position = new Vector3(-3.61f, -3.54f, 1);

            this.explain.GetComponent<Text>().text = "";
            this.explain.GetComponent<Text>().text = "<color=white>" + "모든 C++ 프로그램은 main 함수로부터 실행되며, 하나의 함수는 문장으로 구성된다. "
            + "4~9번 줄에 작성된 main 함수에는 2개의 문장이 있다. 그러한 문장들은 블록안에 작성되는데, 문장은 {(5번 줄)로 시작되며} (9번 줄)로 끝이 난다. "
            + "C++에서 모든 문장은 문 종결자인 ;(세미콜론)으로 끝내야 한다." + "</color>";

            if (CodeGenerator.instance.code0_2 != null)
            {
                Destroy(CodeGenerator.instance.code0_2);
            }
            else
            { ;}
            if (this.s0_2 != null)
            {
                Destroy(this.s0_2);
            }
            else
            { ;}
            count++;
        }
        else if (other.gameObject.tag == "s0_3" && CodeGenerator.instance.array0[2] == 3 && count == 2)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle.transform.position = new Vector3(-3.61f, -3.54f, 1);

            this.explain.GetComponent<Text>().text = "";
            this.explain.GetComponent<Text>().text = "<color=white>" + "모든 C++ 프로그램은 main 함수로부터 실행되며, 하나의 함수는 문장으로 구성된다. "
            + "4~9번 줄에 작성된 main 함수에는 2개의 문장이 있다. 그러한 문장들은 블록안에 작성되는데, 문장은 {(5번 줄)로 시작되며} (9번 줄)로 끝이 난다. "
            + "C++에서 모든 문장은 문 종결자인 ;(세미콜론)으로 끝내야 한다." + "</color>";

            if (CodeGenerator.instance.code0_3 != null)
            {
                Destroy(CodeGenerator.instance.code0_3);
            }
            else
            { ;}
            if (this.s0_3 != null)
            {
                Destroy(this.s0_3);
            }
            else
            { ;}
            count++;
        }
        else if (other.gameObject.tag == "s0_4" && CodeGenerator.instance.array0[2] == 4 && count == 2)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle.transform.position = new Vector3(-3.61f, -3.54f, 1);

            this.explain.GetComponent<Text>().text = "";
            this.explain.GetComponent<Text>().text = "<color=white>" + "모든 C++ 프로그램은 main 함수로부터 실행되며, 하나의 함수는 문장으로 구성된다. "
            + "4~9번 줄에 작성된 main 함수에는 2개의 문장이 있다. 그러한 문장들은 블록안에 작성되는데, 문장은 {(5번 줄)로 시작되며} (9번 줄)로 끝이 난다. "
            + "C++에서 모든 문장은 문 종결자인 ;(세미콜론)으로 끝내야 한다." + "</color>";

            if (CodeGenerator.instance.code0_4 != null)
            {
                Destroy(CodeGenerator.instance.code0_4);
            }
            else
            { ;}
            if (this.s0_4 != null)
            {
                Destroy(this.s0_4);
            }
            else
            { ;}
            count++;
        }

        if (other.gameObject.tag == "s0_0" && CodeGenerator.instance.array0[3] == 0 && count == 3)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle.transform.position = new Vector3(-6.45f, -4.07f, 1);

            this.explain.GetComponent<Text>().text = "";
            this.explain.GetComponent<Text>().text = "<color=white>" + "6번 줄의 문장은 콘솔(화면)에 문자열을 출력하는 것으로 cout 콘솔 출력을 의미한다. "
            + "<< 연산자는 스트림 삽입 연산자로 문자열을 화면으로 보내는 데 사용되며, 문자열은 따옴표(\")로 둘러싸여야 한다." + "</color>";

            if (CodeGenerator.instance.code0_0 != null)
            {
                Destroy(CodeGenerator.instance.code0_0);
            }
            else
            { ;}
            if (this.s0_0 != null)
            {
                Destroy(this.s0_0);
            }
            else
            { ;}
            count++;
        }
        else if (other.gameObject.tag == "s0_1" && CodeGenerator.instance.array0[3] == 1 && count == 3)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle.transform.position = new Vector3(-6.45f, -4.07f, 1);

            this.explain.GetComponent<Text>().text = "";
            this.explain.GetComponent<Text>().text = "<color=white>" + "6번 줄의 문장은 콘솔(화면)에 문자열을 출력하는 것으로 cout 콘솔 출력을 의미한다. "
            + "<< 연산자는 스트림 삽입 연산자로 문자열을 화면으로 보내는 데 사용되며, 문자열은 따옴표(\")로 둘러싸여야 한다." + "</color>";

            if (CodeGenerator.instance.code0_1 != null)
            {
                Destroy(CodeGenerator.instance.code0_1);
            }
            else
            { ;}
            if (this.s0_1 != null)
            {
                Destroy(this.s0_1);
            }
            else
            { ;}
            count++;
        }
        else if (other.gameObject.tag == "s0_2" && CodeGenerator.instance.array0[3] == 2 && count == 3)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle.transform.position = new Vector3(-6.45f, -4.07f, 1);

            this.explain.GetComponent<Text>().text = "";
            this.explain.GetComponent<Text>().text = "<color=white>" + "6번 줄의 문장은 콘솔(화면)에 문자열을 출력하는 것으로 cout 콘솔 출력을 의미한다. "
            + "<< 연산자는 스트림 삽입 연산자로 문자열을 화면으로 보내는 데 사용되며, 문자열은 따옴표(\")로 둘러싸여야 한다." + "</color>";

            if (CodeGenerator.instance.code0_2 != null)
            {
                Destroy(CodeGenerator.instance.code0_2);
            }
            else
            { ;}
            if (this.s0_2 != null)
            {
                Destroy(this.s0_2);
            }
            else
            { ;}
            count++;
        }
        else if (other.gameObject.tag == "s0_3" && CodeGenerator.instance.array0[3] == 3 && count == 3)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle.transform.position = new Vector3(-6.45f, -4.07f, 1);

            this.explain.GetComponent<Text>().text = "";
            this.explain.GetComponent<Text>().text = "<color=white>" + "6번 줄의 문장은 콘솔(화면)에 문자열을 출력하는 것으로 cout 콘솔 출력을 의미한다. "
            + "<< 연산자는 스트림 삽입 연산자로 문자열을 화면으로 보내는 데 사용되며, 문자열은 따옴표(\")로 둘러싸여야 한다." + "</color>";

            if (CodeGenerator.instance.code0_3 != null)
            {
                Destroy(CodeGenerator.instance.code0_3);
            }
            else
            { ;}
            if (this.s0_3 != null)
            {
                Destroy(this.s0_3);
            }
            else
            { ;}
            count++;
        }
        else if (other.gameObject.tag == "s0_4" && CodeGenerator.instance.array0[3] == 4 && count == 3)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();

            this.circle.transform.position = new Vector3(-6.45f, -4.07f, 1);

            this.explain.GetComponent<Text>().text = "";
            this.explain.GetComponent<Text>().text = "<color=white>" + "6번 줄의 문장은 콘솔(화면)에 문자열을 출력하는 것으로 cout 콘솔 출력을 의미한다. "
            + "<< 연산자는 스트림 삽입 연산자로 문자열을 화면으로 보내는 데 사용되며, 문자열은 따옴표(\")로 둘러싸여야 한다." + "</color>";

            if (CodeGenerator.instance.code0_4 != null)
            {
                Destroy(CodeGenerator.instance.code0_4);
            }
            else
            { ;}
            if (this.s0_4 != null)
            {
                Destroy(this.s0_4);
            }
            else
            { ;}
            count++;
        }

        if (other.gameObject.tag == "s0_0" && CodeGenerator.instance.array0[4] == 0 && count == 4)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();
            this.transform.position = new Vector3(1.55f, -3.42f, 0);
            this.talk.transform.localScale = new Vector3(1, 1, 1);
            this.Talk.GetComponent<Text>().text = "<color=white>" + "다음 코드를 알고 싶으면 스페이스바를 눌러봐!" + "</color>";
            isAlive = false;

            this.explain.GetComponent<Text>().text = "";
            this.explain.GetComponent<Text>().text = "<color=white>" + "return 0;은 프로그램의 맨 마지막에 작성되어 있으며 프로그램이 종료되는 것을 의미한다. "
            + "값이 0인 것은 프로그램이 정상적인 종료가 되었음을 의미하는 것이다. 이 문장은 생략할 경우 컴파일러에 따라 프로그램이 잘 동작하거나 아니면 오류를 발생시킬 수 있다. "
            + "그러므로 모든 C++ 컴파일러에서 작성 중인 프로그램이 잘 동작하게 하려면 이 문장을 항상 포함시키는 것이 좋다." + "</color>";

            if (CodeGenerator.instance.code0_0 != null)
            {
                Destroy(CodeGenerator.instance.code0_0);
            }
            else
            { ;}
            if (this.s0_0 != null)
            {
                Destroy(this.s0_0);
            }
            else
            { ;}
            count++;
        }
        else if (other.gameObject.tag == "s0_1" && CodeGenerator.instance.array0[4] == 1 && count == 4)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();
            this.transform.position = new Vector3(1.55f, -3.42f, 0);
            this.talk.transform.localScale = new Vector3(1, 1, 1);
            this.Talk.GetComponent<Text>().text = "<color=white>" + "다음 코드를 알고 싶으면 스페이스바를 눌러봐!" + "</color>";
            isAlive = false;

            this.explain.GetComponent<Text>().text = "";
            this.explain.GetComponent<Text>().text = "<color=white>" + "return 0;은 프로그램의 맨 마지막에 작성되어 있으며 프로그램이 종료되는 것을 의미한다. "
            + "값이 0인 것은 프로그램이 정상적인 종료가 되었음을 의미하는 것이다. 이 문장은 생략할 경우 컴파일러에 따라 프로그램이 잘 동작하거나 아니면 오류를 발생시킬 수 있다. "
            + "그러므로 모든 C++ 컴파일러에서 작성 중인 프로그램이 잘 동작하게 하려면 이 문장을 항상 포함시키는 것이 좋다." + "</color>";

            if (CodeGenerator.instance.code0_1 != null)
            {
                Destroy(CodeGenerator.instance.code0_1);
            }
            else
            { ;}
            if (this.s0_1 != null)
            {
                Destroy(this.s0_1);
            }
            else
            { ;}
            count++;
        }
        else if (other.gameObject.tag == "s0_2" && CodeGenerator.instance.array0[4] == 2 && count == 4)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();
            this.transform.position = new Vector3(1.55f, -3.42f, 0);
            this.talk.transform.localScale = new Vector3(1, 1, 1);
            this.Talk.GetComponent<Text>().text = "<color=white>" + "다음 코드를 알고 싶으면 스페이스바를 눌러봐!" + "</color>";
            isAlive = false;

            this.explain.GetComponent<Text>().text = "";
            this.explain.GetComponent<Text>().text = "<color=white>" + "return 0;은 프로그램의 맨 마지막에 작성되어 있으며 프로그램이 종료되는 것을 의미한다. "
            + "값이 0인 것은 프로그램이 정상적인 종료가 되었음을 의미하는 것이다. 이 문장은 생략할 경우 컴파일러에 따라 프로그램이 잘 동작하거나 아니면 오류를 발생시킬 수 있다. "
            + "그러므로 모든 C++ 컴파일러에서 작성 중인 프로그램이 잘 동작하게 하려면 이 문장을 항상 포함시키는 것이 좋다." + "</color>";

            if (CodeGenerator.instance.code0_2 != null)
            {
                Destroy(CodeGenerator.instance.code0_2);
            }
            else
            { ;}
            if (this.s0_2 != null)
            {
                Destroy(this.s0_2);
            }
            else
            { ;}
            count++;
        }
        else if (other.gameObject.tag == "s0_3" && CodeGenerator.instance.array0[4] == 3 && count == 4)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();
            this.transform.position = new Vector3(1.55f, -3.42f, 0);
            this.talk.transform.localScale = new Vector3(1, 1, 1);
            this.Talk.GetComponent<Text>().text = "<color=white>" + "다음 코드를 알고 싶으면 스페이스바를 눌러봐!" + "</color>";
            isAlive = false;

            this.explain.GetComponent<Text>().text = "";
            this.explain.GetComponent<Text>().text = "<color=white>" + "return 0;은 프로그램의 맨 마지막에 작성되어 있으며 프로그램이 종료되는 것을 의미한다. "
            + "값이 0인 것은 프로그램이 정상적인 종료가 되었음을 의미하는 것이다. 이 문장은 생략할 경우 컴파일러에 따라 프로그램이 잘 동작하거나 아니면 오류를 발생시킬 수 있다. "
            + "그러므로 모든 C++ 컴파일러에서 작성 중인 프로그램이 잘 동작하게 하려면 이 문장을 항상 포함시키는 것이 좋다." + "</color>";

            if (CodeGenerator.instance.code0_3 != null)
            {
                Destroy(CodeGenerator.instance.code0_3);
            }
            else
            { ;}
            if (this.s0_3 != null)
            {
                Destroy(this.s0_3);
            }
            else
            { ;}
            count++;
        }
        else if (other.gameObject.tag == "s0_4" && CodeGenerator.instance.array0[4] == 4 && count == 4)
        {
            this.particle.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 2, 1);
            this.particle.GetComponent<ParticleSystem>().Play();
            this.transform.position = new Vector3(1.55f, -3.42f, 0);
            this.talk.transform.localScale = new Vector3(1, 1, 1);
            this.Talk.GetComponent<Text>().text = "<color=white>" + "다음 코드를 알고 싶으면 스페이스바를 눌러봐!" + "</color>";
            isAlive = false;

            this.explain.GetComponent<Text>().text = "";
            this.explain.GetComponent<Text>().text = "<color=white>" + "return 0;은 프로그램의 맨 마지막에 작성되어 있으며 프로그램이 종료되는 것을 의미한다. "
            + "값이 0인 것은 프로그램이 정상적인 종료가 되었음을 의미하는 것이다. 이 문장은 생략할 경우 컴파일러에 따라 프로그램이 잘 동작하거나 아니면 오류를 발생시킬 수 있다. "
            + "그러므로 모든 C++ 컴파일러에서 작성 중인 프로그램이 잘 동작하게 하려면 이 문장을 항상 포함시키는 것이 좋다." + "</color>";

            if (CodeGenerator.instance.code0_4 != null)
            {
                Destroy(CodeGenerator.instance.code0_4);
            }
            else
            { ;}
            if (this.s0_4 != null)
            {
                Destroy(this.s0_4);
            }
            else
            { ;}
            count++;
        }
    }

   
    void Start()
    {
        count = 0;
        count1 = 0;

        this.s0_0 = GameObject.Find("s0_0");
        this.s0_1 = GameObject.Find("s0_1");
        this.s0_2 = GameObject.Find("s0_2");
        this.s0_3 = GameObject.Find("s0_3");
        this.s0_4 = GameObject.Find("s0_4");
        this.explain = GameObject.Find("explain");
        this.particle = GameObject.Find("Particle System");
        this.circle = GameObject.Find("circle");
        this.talk = GameObject.Find("talk");
        this.Talk = GameObject.Find("Talk");
        this.cam = GameObject.Find("Main Camera");
    }

    void Update()
    {
        this.delta += Time.deltaTime;

        if (this.delta > this.span && count1 == 0)
        {
            this.talk.transform.localScale = new Vector3(0, 0, 0);
            this.Talk.GetComponent<Text>().text = "";
            count1 = 1;
            isAlive = true;
            isAlive1 = true;
        }
        if (isAlive)
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Translate(moveSpeed *Time.deltaTime, 0, 0);
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

        if (isAlive1 == true && isAlive == false)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                code1Count = 1;
                this.cam.transform.position = new Vector3(30, 0, -10);
                this.Talk.GetComponent<Text>().text = "";
                this.explain.GetComponent<Text>().text = "";
                Destroy(gameObject);
            }
        }

        if (this.transform.position.x >= 9.7f || this.transform.position.x <= -9.7f)
        {
            this.transform.position = new Vector3(1.55f, -3.42f, 0);
        }
        else if (this.transform.position.y >= 5.0f || this.transform.position.y <= -7.0f)
        {
            this.transform.position = new Vector3(1.55f, -3.42f, 0);
        }
    }
}
