﻿Feature: FriendSearch
Переходим в Сообщение
Находим нужного человека
Заходим к нему на страницу
Пишем сообщение
Отправляем сообщение
Сделали проверку, отрпавка сообщения

@mytag
Scenario: FriendSearch
	Given Вводим логин и пароль "Логин" "Пароль"
	Then Проверка выполненного логина
	When Заходим в Сообщения
	And В строке Поиск находим "Имя Фамилия"
	And Нажать на аватарку
	And Написать сообщение "Сообщщение"
	And Отправить сообщение