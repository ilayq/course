from sqlite3 import connect


con = connect('db.db')

cur = con.cursor()
'''
cur.execute('create table authors (id int, name varchar(50), surname varchar(50), birth_date date)')

cur.execute('create table items (id int,type int,title varchar(50),author_id int,genre varchar(50),release_date date,album varchar(50),publishing varchar(50),studio varchar(50))')
'''

cur.execute('insert into authors(name, surname, birth_date) values ("sun", "hui v chai", "2003-12-16")')


con.commit()
con.close()
