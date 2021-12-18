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

К числу ее достоинств можно отнести следующие модули: Delivery – управление доставкой готовой продукции, TimeKeeper – контроль рабочего времени персонала, StoreHouse – складские операции[2]. Но эта система имеет такие минусы как: жалобы на медленную работу технической поддержки и сложности в освоении функционала.

Системы должны быть, в первую очередь, ориентированы на пользователя. Удобный и понятный интерфейс-одна из главных задач разработчика. 

В системе, которую планируется спроектрировать и внедрить, должен быть удобный и легкий в использовании графический интерфейс. 


<a name="systemdevelopment"/>

## 3 Разработка системы


<a name="systemdesign"/>

## 3.1 Проектирование системы

Разработка информационной системы начинается с проектрирования USE CASE диаграммы[3], отображающей действующие лица данной системы: Менеджер, Официант, Шеф-повар, Клиент.(см.рисунок 1). 

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

На основе всех хранилищ из DFD диаграммы разрабатывается ER диаграмма[5]. (см.рисунок 3)

![image](https://user-images.githubusercontent.com/91078274/146603988-4cf1c0ff-13ee-4efe-ade9-f66102a43085.png)
                                               
                                               Рисунок 3-ER Диаграмма
                                               
Каждая из сущностей имеет поля, которые ее описывают, а также типы данных этих полей. 

Сущность Menu характеризуется такими полями как: IdMenu целочисленного типа, Dish целочисленного типа, Photo типа image, Ingridient символьного типа, Portion целочисленного типа, Price денежного типа. Аналогично и у остальных сущностей. 

<a name="systemrealise"/>

## 3.2 Реализация системы

На основе ER Диаграммы создаются классы на языке программирования C#. Рассмотрим пример класса Menu (см.рисунок 4).

![image](https://user-images.githubusercontent.com/91078274/146607486-490ff439-238a-4783-b5c1-b9f3fb8c8005.png)

                                               Рисунок 4-Листинг класса Menu
                                               
 Аналогичным образом создаются классы для всех сущностей (см.рисунок 5)
 
 ![image](https://user-images.githubusercontent.com/91078274/146607997-187150ae-80d1-4cf7-abce-017376408b09.png)
 
                                               Рисунок 5-Список созданных классов

Затем отпределяемся, где классы будут храниться, создав репозитории (см.рисунок 6). Также создаем общее хранилище (см.рисунок7).

![image](https://user-images.githubusercontent.com/91078274/146609230-bc37506a-e260-4055-bb13-91cea90ee3e7.png)

                                               Рисунок 6-Хранилище класса Menu
                                                
![image](https://user-images.githubusercontent.com/91078274/146609478-33ac8edb-85d0-4cd8-ba04-4a2727baa4c5.png)
                                               
                                               Рисунок 7-Общее хранилище
                                               
Далее разрабатываются Web-методы, включающие базовые операции CRUD[6] для каждой из сущностей, отображающих предметную область. Рассмотрим в качестве примера контроллер для класса Menu. (см.рисунок 8).         

![image](https://user-images.githubusercontent.com/91078274/146610587-c3904b2a-275d-4891-90a4-810249618527.png)

                                               Рисунок 8-Листинг контроллера Menu

Аналогичным образом создаем контроллеры для каждой из сущностей.(см.рисунок 9)

![image](https://user-images.githubusercontent.com/91078274/146610803-4d0f44f4-a770-418b-887b-4b92915b1286.png)

                                               Рисунок 9-Список контроллеров для всех сущностей
                                               
На данном этапе проектирование системы завершается, далее необходимо ее протестировать.

<a name="Checkingandtestingthesystem"/>

## 4 Проверка и тестирование системы

После запуска проекта автоматически открывается страница Swagger UI со списком сущностей и операций над ними (см.рисунок 10).

![image](https://user-images.githubusercontent.com/91078274/146634336-104ffb59-aa44-4569-bc5e-9bf2647635d9.png)

                                               Рисунок 10-Cтраница Swagger UI

Рассмотрим работу методов CRUD (Create - создание, Read - чтение, Update - обновление, Delete - удаление) на примере сущности Menu (см.рисунок 11).

![image](https://user-images.githubusercontent.com/91078274/146634408-a21143c7-51db-4059-8035-1d7881e860f7.png)

                                               Рисунок 11-Проверка работы методов CRUD
                                               
 1. Create позволяет добавлять новые строки в таблицу (см.рисунок 12). 

![image](https://user-images.githubusercontent.com/91078274/146634490-dea78f6f-d640-4fb1-805f-1a508e4011eb.png)
                                            
                                               Рисунок 12-Окно метода Create
                                               
 Далее, ввод необходимых данных о меню в соответствующие поля (см.рисунок 13). 
 
 ![image](https://user-images.githubusercontent.com/91078274/146634544-45024caf-42ec-4483-b232-27f6410cdb21.png)

                                           Рисунок 13-Заполнение полей в методе Create
                                           
 После выполнения операции сервер выводит ответ в следующем виде (см.рисунок 14).  
 
 ![image](https://user-images.githubusercontent.com/91078274/146634616-eaaa86bb-46b1-4ffb-8eae-c63762d2ab9f.png)

                                       Рисунок 14- Результат выполнения в методе Create
                                       
2.Функция Read-функция чтения, позволяющая извлекать интересующие записи и считывать их значения (см.рисунок 15).

![image](https://user-images.githubusercontent.com/91078274/146634674-2d2d016c-2b44-4bba-8bd2-b9b339a8cb02.png)

                                               Рисунок 15-Окно метода Read    
                                               
 Считывание информации об уже созданном меню по его Id выдает следующую информацию после выполнения (см.рисунок 16). 
 
 ![image](https://user-images.githubusercontent.com/91078274/146634716-7c004bb0-cc4b-4243-8317-450ec32a0868.png)

                                       Рисунок 16- Результат выполнения в методе Read
 
 3. Update- функция, использующаяся для изменения существующих записей в базе данных (см.рисунок 17).

![image](https://user-images.githubusercontent.com/91078274/146634812-9c291f32-cc80-4c5d-a495-00289a26c7eb.png)

                                                Рисунок 17-Окно метода Update
                                                
Для того, чтобы изменить информацию об меню, для этого сначала нужно ввести его номер, после - новые данные (см.рисунок 18).   

![image](https://user-images.githubusercontent.com/91078274/146634870-1e90c57c-b2ef-438c-860c-dffef43c8551.png)

                                       Рисунок 18-Заполнение полей в методе Update
                                       
 После успешного выполнения операции сервер выдаёт обновленную информацию о том же меню (см.рисунок 19).  
 
 ![image](https://user-images.githubusercontent.com/91078274/146634922-27f112fc-1ad6-4749-baaf-9c78249fff6b.png)

                                      Рисунок 19- Результат выполнения в методе Update
                                      
 Проверим с помощью функции Read вывод обновленной информации. После успешного выполнения сервер выдает обновленную информацию о меню(см.рисунок 20). 
 
 ![image](https://user-images.githubusercontent.com/91078274/146634958-98340f6a-1be9-4536-8074-da3d56191d6b.png)

                                       Рисунок 20- Результат выполнения в методе Read
                                       
 4. Delete- функция, использующаяся для удаления записей. Если операция удаления сработает успешно, то ответ сервера будет "true", иначе "false" (см.рисунок 21).

![image](https://user-images.githubusercontent.com/91078274/146634987-5c85d204-b04c-4457-962c-7a03077a34a5.png)

                                                 Рисунок 21-Окно метода Delete
                                                 
 Удаление меню по его Id (см.рисунок 22).   
 
 ![image](https://user-images.githubusercontent.com/91078274/146635015-36713b57-e34e-43e4-9e93-971b5021f429.png)

                                               Рисунок 22 - Работа с методом Delete

После успешного выполнения операции сервер выдаёт "true" (см.рисунок 23). 

![image](https://user-images.githubusercontent.com/91078274/146635045-63c87d0e-dcb9-4613-a9c0-2f9a2be09227.png)

                                          Рисунок 23- Результат выполнения в методе Delete
                                          
Проверим с помощью функции Read информацию о меню. Программа выдает ошибку, что означет, что информаци. о меню по его Id была удалена и ее невозможно найти.(см.рисунок 24)     

![image](https://user-images.githubusercontent.com/91078274/146635083-4862e601-5847-4a92-9c5a-e0a93c997d73.png)

                                           Рисунок 24- Результат выполнения в методе Read

 
                                       
                                       
<a name="Conclusion"/>

## Заключение
 
<a name="Listofliterature"/>
 
## Список использованных источников
[1] Система R-keeper: что это такое, принцип работы программы - лучшее программное обеспечение для ресторанов и кафе [электронный ресурс]/Бобков Олег-Особенности программы R-Keeper и принцип ее работы, 2020. -Режим доступа:https://www.cleverence.ru/articles/elektronnaya-kommertsiya/sistema-r-keeper-chto-eto-takoe-printsip-raboty-programmy-luchshee-programmnoe-obespechenie-dlya-res/, свободный (дата обращения 01.12.2021)

[2] Что собой представляет R-Keeper? [электронный ресурс]/ Компания "ПОСЛЭНД" - R-Keeper: и это все о нем, 2019. -Режим доступа:https://www.posland.ru/articles/r-keeper/, свободный (дата обращения 01.12.2021)

[3] Диаграмма сценариев [электронный ресурс]/Luxoft-Диаграмма сценариев использования в процессе разработки ПО, 2016. -Режим доступа:https://habr.com/ru/company/luxoft/blog/312188/ свободный (дата обращения 03.12.2021)

[4] Как создавать нотации DFD [электронный ресурс]/Trinion-Что такое DFD (диаграммы потоков данных), 2017. -Режим доступа:https://habr.com/ru/company/trinion/blog/340064/ свободный (дата обращения 03.12.2021)

[5] Что такое ER - диаграмма и как ее создать [электронный ресурс]/Lucid - "Lucidchart" Что такое ER-диаграмма, 2021, Режим доступа:https://www.lucidchart.com/pages/ru/erd-диаграмма, свободный (дата обращения 06.12.2021)

[6] Что такое CRUD операции [электронный ресурс]/BEST PROGRAMMER - Что такое CRUD операции?, 2021 - Режим доступа:https://bestprogrammer.ru/izuchenie/chto-takoe-crud-operatsii, свободный (дата обращения 06.12.2021)

[7]

[8]
