-- 1) test veritabanınızda employee isimli sütun bilgileri id(INTEGER), name VARCHAR(50), birthday DATE, email VARCHAR(100) olan bir tablo oluşturalım.
CREATE TABLE employee (
   id SERIAL,
	name VARCHAR(50),
	birthday DATE,
	email VARCHAR(100)
);

-- 2) Oluşturduğumuz employee tablosuna 'Mockaroo' servisini kullanarak 50 adet veri ekleyelim.
insert into author (first_name, last_name, email, birthday) values ('Bee', 'Demageard', 'bdemageard0@answers.com', '2001-10-06');
insert into author (first_name, last_name, email, birthday) values ('Tamarra', 'Pablos', 'tpablos1@auda.org.au', '1984-11-29');
insert into author (first_name, last_name, email, birthday) values ('Levy', 'Cleever', null, null);
insert into author (first_name, last_name, email, birthday) values ('Griff', 'Easterling', 'geasterling3@huffingtonpost.com', '1982-10-05');
insert into author (first_name, last_name, email, birthday) values ('Patience', 'Dreghorn', 'pdreghorn4@de.vu', '1965-10-29');
insert into author (first_name, last_name, email, birthday) values ('Ignaz', 'Eytel', 'ieytel5@amazonaws.com', '1950-11-24');
insert into author (first_name, last_name, email, birthday) values ('Aubree', 'Cottu', null, null);
insert into author (first_name, last_name, email, birthday) values ('Audrey', 'Moseley', 'amoseley7@histats.com', '1967-08-29');
insert into author (first_name, last_name, email, birthday) values ('Jania', 'Gard', 'jgard8@dyndns.org', '1974-05-02');
insert into author (first_name, last_name, email, birthday) values ('Oriana', 'McMonies', 'omcmonies9@yelp.com', '1983-09-06');
insert into author (first_name, last_name, email, birthday) values ('Christiane', 'Rhys', 'crhysa@chicagotribune.com', '1993-12-23');
insert into author (first_name, last_name, email, birthday) values ('Saunder', 'Menichi', 'smenichib@istockphoto.com', '1963-09-02');
insert into author (first_name, last_name, email, birthday) values ('Renard', 'Curneen', 'rcurneenc@bravesites.com', '1950-09-07');
insert into author (first_name, last_name, email, birthday) values ('Ossie', 'Gregori', 'ogregorid@bbc.co.uk', '1976-03-12');
insert into author (first_name, last_name, email, birthday) values ('Irena', 'Heymes', 'iheymese@alibaba.com', '1968-04-28');
insert into author (first_name, last_name, email, birthday) values ('Hilton', 'Piggrem', 'hpiggremf@last.fm', '1976-03-25');
insert into author (first_name, last_name, email, birthday) values ('Alvin', 'Deetlof', 'adeetlofg@mozilla.com', '1968-04-03');
insert into author (first_name, last_name, email, birthday) values ('Georges', 'Sheehy', 'gsheehyh@chron.com', '1976-06-19');
insert into author (first_name, last_name, email, birthday) values ('Randy', 'Routley', 'rroutleyi@etsy.com', '1996-05-09');
insert into author (first_name, last_name, email, birthday) values ('Mellicent', 'Christopher', 'mchristopherj@who.int', '1986-06-08');
insert into author (first_name, last_name, email, birthday) values ('Val', 'Klementz', 'vklementzk@java.com', '1966-02-21');
insert into author (first_name, last_name, email, birthday) values ('Wye', 'Dibling', 'wdiblingl@nba.com', '1993-11-11');
insert into author (first_name, last_name, email, birthday) values ('Mitzi', 'Hanmore', null, null);
insert into author (first_name, last_name, email, birthday) values ('Shannon', 'Dripps', 'sdrippsn@thetimes.co.uk', '1978-03-04');
insert into author (first_name, last_name, email, birthday) values ('Danice', 'Stansfield', 'dstansfieldo@bloglovin.com', '1984-10-14');
insert into author (first_name, last_name, email, birthday) values ('Veda', 'Nettle', 'vnettlep@hhs.gov', '1969-04-10');
insert into author (first_name, last_name, email, birthday) values ('Jere', 'Hutchinges', 'jhutchingesq@theglobeandmail.com', '1994-07-15');
insert into author (first_name, last_name, email, birthday) values ('Leda', 'Blitzer', 'lblitzerr@vimeo.com', '1983-10-04');
insert into author (first_name, last_name, email, birthday) values ('Marys', 'Malling', 'mmallings@last.fm', '1998-08-30');
insert into author (first_name, last_name, email, birthday) values ('Shannah', 'Santostefano.', 'ssantostefanot@google.fr', '1972-10-20');
insert into author (first_name, last_name, email, birthday) values ('Leeann', 'Brimm', 'lbrimmu@google.fr', '1979-06-05');
insert into author (first_name, last_name, email, birthday) values ('Jacynth', 'Exelby', 'jexelbyv@4shared.com', '1957-11-09');
insert into author (first_name, last_name, email, birthday) values ('Erminie', 'Threader', 'ethreaderw@reddit.com', '1976-04-02');
insert into author (first_name, last_name, email, birthday) values ('Darleen', 'Blaker', 'dblakerx@cnet.com', '2001-04-23');
insert into author (first_name, last_name, email, birthday) values ('Kean', 'Chawner', 'kchawnery@netvibes.com', '1959-09-26');
insert into author (first_name, last_name, email, birthday) values ('Damien', 'Addess', 'daddessz@geocities.jp', '1960-06-01');
insert into author (first_name, last_name, email, birthday) values ('Clarisse', 'Thomasset', 'cthomasset10@gnu.org', '1964-08-21');
insert into author (first_name, last_name, email, birthday) values ('Elfreda', 'Bedham', 'ebedham11@tiny.cc', '1979-05-22');
insert into author (first_name, last_name, email, birthday) values ('Georgianne', 'Cull', 'gcull12@cloudflare.com', '1959-06-13');
insert into author (first_name, last_name, email, birthday) values ('Christi', 'Milch', 'cmilch13@ft.com', '1994-11-18');
insert into author (first_name, last_name, email, birthday) values ('Goddart', 'Episcopio', 'gepiscopio14@booking.com', '1982-12-14');
insert into author (first_name, last_name, email, birthday) values ('Meara', 'Kiely', 'mkiely15@blogs.com', '1998-03-24');
insert into author (first_name, last_name, email, birthday) values ('Andonis', 'Keetch', 'akeetch16@nydailynews.com', '1978-08-25');
insert into author (first_name, last_name, email, birthday) values ('Tuckie', 'Lissandrini', 'tlissandrini17@sourceforge.net', '1974-05-19');
insert into author (first_name, last_name, email, birthday) values ('Andre', 'Kordas', 'akordas18@theglobeandmail.com', '1960-01-24');
insert into author (first_name, last_name, email, birthday) values ('Clyde', 'Virgin', 'cvirgin19@google.com.br', '1956-01-15');
insert into author (first_name, last_name, email, birthday) values ('Kalindi', 'Tithacott', 'ktithacott1a@constantcontact.com', '1954-02-04');
insert into author (first_name, last_name, email, birthday) values ('Reggy', 'Cruddace', 'rcruddace1b@parallels.com', '1953-09-09');
insert into author (first_name, last_name, email, birthday) values ('Flemming', 'Mounsie', 'fmounsie1c@cnbc.com', '1982-06-24');
insert into author (first_name, last_name, email, birthday) values ('Arie', 'Lockton', 'alockton1d@goo.ne.jp', '1976-08-19');


-- 3) Sütunların her birine göre diğer sütunları güncelleyecek 5 adet UPDATE işlemi yapalım.
UPDATE author
SET first_name = 'Burak',
    last_name = 'Beştaş',
	email = 'mabbestas@gmail.com',
	birthday = '1980-01-01'
WHERE id = 1;

UPDATE author
SET first_name = 'Mert',
    last_name = 'Aydın',
WHERE id = 4;

UPDATE author
SET email = 'serdargur@hotmail.com',
WHERE id = 9;

UPDATE author
SET birthday = '1991-06-01'
WHERE id = 12;

UPDATE author
SET last_name = 'Yüksel',
WHERE id = 19;

-- 4) Sütunların her birine göre ilgili satırı silecek 5 adet DELETE işlemi yapalım.
DELETE FROM author
WHERE id = 1;

DELETE FROM author
WHERE first_name = 'Selin';

DELETE FROM author
WHERE last_name = 'Gürcan';

DELETE FROM author
WHERE email = 'ulasguney@gmail.com';

DELETE FROM author
WHERE birthday = '1995-09-17';