# Информационная система управления рестораном
## Содержание
[Введение](#introduction)  

[1 Описание предметной области](#domainDescription)  

[2 Сравнительный анализ ](#existingSoftware)

[3 Проектирование системы](#Systemdesign)

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



<a name="Systemdesign"/>

## 3 Разработка системы

Разработка информационной системы начинается с проектрирования диаграммы, отображающей действующие лица данной системы: Менеджер, Официант, Шеф-повар, Клиент.




### 3.1 Проектирование системы

### 3.2 Реализация системы

<a name="Checkingandtestingthesystem"/>

## 4 Проверка и тестирование системы

<a name="Conclusion"/>

## Заключение
 
<a name="Listofliterature"/>
 
## Список использованных источников
[1] https://www.cleverence.ru/articles/elektronnaya-kommertsiya/sistema-r-keeper-chto-eto-takoe-printsip-raboty-programmy-luchshee-programmnoe-obespechenie-dlya-res/

[2] https://www.posland.ru/articles/r-keeper/

[3] https://eto-razvod.ru/review/rkeeper/


