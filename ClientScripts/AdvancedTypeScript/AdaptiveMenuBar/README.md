﻿# AdaptiveMenuBar

Этот каталог содержит пример работы с всплывающим меню.

## Настройка среды

**Перечень необходимых инструментов:** 
* [NodeJS v10.6+](https://nodejs.org/en/)

## Сборка и установка

1. Открыть консоль в папке AdaptiveMenuBarWebExtension и выполнить команду npm install, потом  npm update и в конце npm run build:prod
2. Скопировать каталог SamplesOutput\Site\Content\Modules\AdaptiveMenuBarWebExtension в каталог "Путь к установленному Web-клиент\Site\Content\Modules"
3. Перезапустить IIS

## Проверка примера

1. Запустить конструктор разметок
2. Импортировать разметку из файла AdaptiveMenuBarLayout.xml без условий использования. При этом будет добавлена разметка в тип карточки документ, вид ДокументУД\Исходящий
3. Сделать солюшн AdaptiveMenuBarLayout активным.
4. Перезапустить IIS
5. Открыть новый документ ДокументУД\Исходящий и нажать кнопку редактировать. При этом должна открыться разметка с кнопкой вызова модального окна и текстовым полем. 
6. При нажатии на кнопку ShowAdaptiveMenuBar появляется всплывающее меню. при нажатии на пунктах меню их название появляется в всплывающем сообщении.


## Проект AdaptiveMenuBarWebExtension

Проект-расширение клиентской части Web-клиент. Содержит клиентский скрипт c функцией showAdaptiveMenuBar реализующей отображение AdaptiveMenuBarComponent.
AdaptiveMenuBarComponent - React компонент, представляющий всплывающее меню.