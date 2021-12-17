# Информационная система управления рестораном
## Содержание
[Введение](#introduction)  

[1 Описание предметной области](#domainDescription)  

[2 Сравнительный анализ ](#existingSoftware)

[3 Разработка системы](#systemdevelopment)

[3.1 Проектирование системы](#systemdesign)

[3.2 Реализация системы](#systemrealise)

[4 Проверка и тестирование системы](#Checkingandtestingthesystem)

[Заключение](#Conclusion)

[Список литературы](#Listofliterature)

<a name="introduction"/>

## Введение

В рассматриваемой работе необходимо спроектировать информационную систему для организации работы ресторана. Услуги, оказываемые физическим лицам в местах общественного питания, являются одной из социально значимых сфер экономики, обеспечивают удовлетворение потребностей человека, играют значительную роль в создании комфортных условий для работы и отдыха.

Владелец ресторана планирует внедрить информационную систему, облегчающую процесс обмена информацией между работниками. Деятельность предприятия специализируется на быстром обслуживании: незамедлительное формирование заказа и его приготовление; также на выдаче чеков, контролировании недостающей продукции. Главной характеристикой информационной системы должна являться эффективная и слаженная работа ресторана и увеличение его выручки. 

<a name="domainDescription"/>

## 1 Описание предметной области

Есть следующие группы пользователей: Менеджер, Официант, Шеф-повар, Клиент.

В ресторан приходит клиент, получает меню и начинает его просмотр. Проанализировав позиции меню, клиент решает сделать заказ. Запрос на обслуживание поступает в журнал обслуживания. 

Официант, получив запрос, формирует заказ, открывает счет и передает заказ на кухню. Заказ попадает в журнал электронной очереди, откуда он поступает шеф-повару, который начинает его готовку. Когда блюдо готово, уведомление о его готовности получает официант из журнала электронной очереди. После обслуживания клиент оплачивает счет. Также у него есть возможность оставить отзыв. 

Клиент должен иметь возможность получать полные сведения о блюдах в меню (фотографии, состав, подсчет каллорий).

В задачи шеф-повара также входит формирование списка недостающей продукции и формирование меню. 

При работе с системой менеджер решает следующие задачи: формирование рейтинга блюд и качества обслуживания, получение недостающей продукции, подсчет прибыли в конце рабочей смены. В его полномочия также входит содействие в формировании меню: дегустация, отбор блюд в меню, установление цен, разработка дизайна, печать окончательного варинта меню.

Сейчас система автоматизации работы мест общественного питания-необходимое условие конкурентоспособности всего бизнеса. Без специальных программ не получится организовать контроль над работой персонала, продажи не поднимутся, а издержки будут постоянно расти. Все процессы, которые происходят в заведении, нужно отслеживать. Важно соединить в одном программном обеспечении, которое сделает проще жизнь работникам и руководству, деятельность кухни, зала, склада и кассы, а также учесть возможность проводить бухгалтерию.

<a name="existingSoftware"/>

## 2 Сравнительный анализ

Существует множество разнообразых ПО, которые справляются с такими задачами как: продажи, внесение изменений, касающиеся клиентов, то есть принятие заказов, обслуживание, совершение рассчета, выдача чека о полученной услуге. Одной из наиболее известных программ явлется R-Keeper[1]. Ее используют для автоматизации деятельности ресторана, бара. Она имеет функционалы для каждого из работников. Первую версию создали в 1992 году, потом постепенно модернизировали. Сейчас ею пользуются больше 37 000 заведений. 

К числу ее достоинств можно отнести следующие модули: Delivery – управление доставкой готовой продукции, TimeKeeper – контроль рабочего времени персонала, StoreHouse – складские операции[2]. Но эта система имеет такие минусы как: жалобы на медленную работу технической поддержки и сложности в освоении функционала.[3]

Системы должны быть, в первую очередь, ориентированы на пользователя. Удобный и понятный интерфейс-одна из главных задач разработчика. 

В системе, которую планируется спроектрировать и внедрить, должен быть удобный и легкий в использовании графический интерфейс. 



<a name="systemdevelopment"/>

## 3 Разработка системы


<a name="systemdesign"/>

## 3.1 Проектирование системы

Разработка информационной системы начинается с проектрирования USE CASE диаграммы, отображающей действующие лица данной системы: Менеджер, Официант, Шеф-повар, Клиент.(см.рисунок 1). 

![image](https://user-images.githubusercontent.com/91078274/144632262-0d4124ff-23d6-4703-ad9a-2376dfb213e1.png)

                                             Рисунок 1-USE CASE Диаграмма
                                             
Каждая из сущностей на данной диаграмме выполняет свои функции. Рассмотрим обязанности Менеджера: он формирует рейтинг блюд и качества обслуживания, подсчитывает прибыль в конце рабочей смены, получает недостающую продукцию, устанавливает цены в меню и участвует в разработке его дизайна. 

Задачами Официанта являются такие действия, как формирование заказа, вместе с тем открытие счета, передача заказа на кухню и обслуживание клиента. 

Рассмотрим задачи Шеф-повара. Его прямая задача-готовка блюд. Помимо этого, он принимает заказы, формирует позиции меню и список недостающей продукции.

По приходу в ресторан Клиент получает меню, просматривает его и делает заказ. После обслуживания Клиент оплачивает счет и может оставить отзыв, выражающийся в оценке качества обслуживания и качества блюд.                                             

На основе данной диаграммы разрабатвается DFD (data flow diagrams)[4].(см.рисунок 2) 

![image](https://user-images.githubusercontent.com/91078274/144634488-972acf9d-cc66-43b3-912f-1991d23f1fe7.png)

                                                Рисунок 2-DFD Диаграмма

На DFD диаграмме отображен весь процесс обмена данными между действующими лицами в данной предметной области. Клиент приходит в ресторан, получает меню, сформированное Шеф-поваром при участии Менеджера в разработке дизайна, и начинает анализировать его позиции. За более расширенной информацией о том или ином блюде можно обратиться к карточке интересующего блюда. 

Если Клиент не определился с выбором блюда, он вновь начинает анализ позиций меню, если же Клиент выбрал блюда, он попадает в журнал запросов на обслуживание, после чего к нему подходит Официант и формирует заказ, при этом открывая счет, после чего последний передает заказ на кухню, а в журнале электронной очереди делается отметка о Клиенте, сделавшем заказ. 

На кухне Шеф-повар принимает заказ и начинает его готовку. После приготовления блюда, в журнале электронной очереди делается отметка о том, что Клиенту был приготовлен заказ и отправлен за его столик. Помимо приготовления заказа, Шеф-повар формирует список недостащей продукции и отправляет его в соответствующий журнал, откуда Менеджер получает информацию о необходимых продуктах, заказывает их и получает, сделав в данном журнале пометку о том, что недостающая продукция есть в наличии.

Официант получает с кухни уведомление о том, что заказ готов, забирает его и обслуживает Клиента, также сделав пометку по окончании обслуживания в журнале электронной очереди о том, что Клиент обслужен и больше не числится в очереди. В таком случае Клиент оплачивает счет и может оставить отзыв.

Отзывы, оставленые Клиентами, попадают в журнал отзывов и Менеджер исходя из него формирует оценку качества обслуживания и приготовленных блюд. 

При оплате Клиентами счетов, все деньги поступают в кассу. Оттуда Менеджер и подсчитывает прибыль. 

На основе всех хранилищ из DFD диаграммы разрабатывается ER диаграмма.[5] (см.рисунок 3)

![image](https://user-images.githubusercontent.com/91078274/146603988-4cf1c0ff-13ee-4efe-ade9-f66102a43085.png)
                                               
                                               Рисунок 3-ER Диаграмма
                                               
Каждая из сущностей имеет поля, которые ее описывают, а также типы данных этих полей. 

Сущность Menu характеризуется такими полями как: IdMenu целочисленного типа, Dish целочисленного типа, Photo типа image, Ingridient символьного типа, Portion целочисленного типа, Price денежного типа. Аналогично и у остальных сущностей. 

<a name="systemrealise"/>

## 3.2 Реализация системы

На ER Диаграммы создаются классы на языке программирования C#. Рассмотрим класс Menu (см.рисунок 4).

![image](https://user-images.githubusercontent.com/91078274/146607486-490ff439-238a-4783-b5c1-b9f3fb8c8005.png)

                                               Рисунок 4-листинг класса Menu



<a name="Checkingandtestingthesystem"/>

## 4 Проверка и тестирование системы

<a name="Conclusion"/>

## Заключение
 
<a name="Listofliterature"/>
 
## Список использованных источников
[1] https://www.cleverence.ru/articles/elektronnaya-kommertsiya/sistema-r-keeper-chto-eto-takoe-printsip-raboty-programmy-luchshee-programmnoe-obespechenie-dlya-res/

[2] https://www.posland.ru/articles/r-keeper/

[3] https://eto-razvod.ru/review/rkeeper/

[4] https://habr.com/ru/company/trinion/blog/340064/


