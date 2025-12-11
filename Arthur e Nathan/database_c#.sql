create database if not exists trabalho;
use trabalho;

create table if not exists usuario 
(
id int auto_increment primary key,
email varchar(100),
 senha varchar(255)
);
 
select * from usuario;

-- Criação da tabela de Movimento Retilíneo Uniforme --

CREATE TABLE mu 
(
    s double null,
    s0 double null,
    v double null,
    t double null
);

-- Criação da tabela de Movimento Retilínio Uniformemente Variado --

CREATE TABLE muv 
(
    s double null,
    s0 double null,
    v double null,
    v0 double null,
    a double null,
    t double null
);

-- Criação da tabela de Velocidade Média --

create table vm 
(
s double null,
s0 double null,
t double null,
t0 double null,
vm double null
);

-- Criação da tabela de Aceleração Média --

create table am 
(
v double null,
v0 double null,
t double null,
t0 double null,
am double null
);

-- Criação da tabela de Força / Segunda Lei de Newton --

create table forca 
(
f double null,
m double null,
a double null
);

-- Criação das contas da variável faltante do Movimento Retilíneo Uniforme --

CREATE VIEW mu_calculos AS
SELECT *,
    CASE 
        WHEN s IS NULL AND s0 IS NOT NULL AND v IS NOT NULL AND t IS NOT NULL THEN s0 + v * t
        ELSE s
    END AS s_calculado,
    CASE 
        WHEN s0 IS NULL AND s IS NOT NULL AND v IS NOT NULL AND t IS NOT NULL THEN s - v * t
        ELSE s0
    END AS s0_calculado,
    CASE 
        WHEN v IS NULL AND s IS NOT NULL AND s0 IS NOT NULL AND t IS NOT NULL THEN (s - s0) / t
        ELSE v
    END AS v_calculado,
    CASE 
        WHEN t IS NULL AND s IS NOT NULL AND s0 IS NOT NULL AND v IS NOT NULL THEN (s - s0) / v
        ELSE t
    END AS t_calculado
FROM mu;

-- FIM do Movimento Retilíneo Uniforme --

-- Criação das contas da variável faltante do Movimento Uniformemente Variado --

-- Fórmula da Função Horária da Velocidade --

CREATE VIEW muv_h AS
SELECT *,
    CASE 
        WHEN v IS NULL AND v0 IS NOT NULL AND a IS NOT NULL AND t IS NOT NULL THEN v0 + a * t
        ELSE v
    END AS v_calculado,
    CASE 
        WHEN v0 IS NULL AND v IS NOT NULL AND a IS NOT NULL AND t IS NOT NULL THEN v - a * t
        ELSE v0
    END AS v0_calculado,
    CASE 
        WHEN a IS NULL AND v IS NOT NULL AND v0 IS NOT NULL AND t IS NOT NULL THEN (v - v0) / t
        ELSE a
    END AS a_calculado,
    CASE 
        WHEN t IS NULL AND v IS NOT NULL AND v0 IS NOT NULL AND a IS NOT NULL THEN (v - v0) / a
        ELSE t
    END AS t_calculado
FROM muv;

-- FIM da Função Horária da Velocidade --

-- Fórmula da Função Horária da Posição (Sorvetão) --

CREATE VIEW muv_s AS
SELECT *,
    CASE 
        WHEN s IS NULL AND s0 IS NOT NULL AND v0 IS NOT NULL AND a IS NOT NULL AND t IS NOT NULL THEN s0 + v0 * t + (a * t * t) / 2
        ELSE s
    END AS s_calculado,
    CASE 
        WHEN s0 IS NULL AND s IS NOT NULL AND v0 IS NOT NULL AND a IS NOT NULL AND t IS NOT NULL THEN s - v0 * t - (a * t * t) / 2
        ELSE s0
    END AS s0_calculado,
    CASE 
        WHEN v0 IS NULL AND s IS NOT NULL AND s0 IS NOT NULL AND a IS NOT NULL AND t IS NOT NULL THEN (s - s0 - (a * t * t) / 2) / t
        ELSE v0
    END AS v0_calculado,
    CASE 
        WHEN a IS NULL AND s IS NOT NULL AND s0 IS NOT NULL AND v0 IS NOT NULL AND t IS NOT NULL THEN 2 * (s - s0 - (v0 * t)) / power(t, 2)
        ELSE a
    END AS a_calculado,
    CASE 
        WHEN t IS NULL AND s IS NOT NULL AND s0 IS NOT NULL AND v0 IS NOT NULL AND a IS NOT NULL THEN (-(v0) + sqrt(power(v0, 2) - 2 * a * (s0 - s))) / a 
        ELSE t
    END AS t_calculado
FROM muv;

select * from muv_s;

-- FIM da Função Horária da Posição (Sorvetão) --

-- Fórmula da Equação de Torricelli --

CREATE VIEW muv_t AS
SELECT *,
    CASE 
        WHEN v IS NULL AND v0 IS NOT NULL AND s IS NOT NULL AND s0 IS NOT NULL AND a IS NOT NULL THEN sqrt(v0 * v0 + 2 * a * (s - s0))
        ELSE v
    END AS v_calculado,
    CASE 
        WHEN v0 IS NULL AND v IS NOT NULL AND s IS NOT NULL AND s0 IS NOT NULL AND a IS NOT NULL THEN sqrt(v * v - 2 * a * (s - s0))
        ELSE v0
    END AS v0_calculado,
    CASE 
        WHEN s IS NULL AND v IS NOT NULL AND v0 IS NOT NULL AND s0 IS NOT NULL AND a IS NOT NULL THEN s0 + (v * v - v0 * v0) / (2 * a)
        ELSE s
    END AS s_calculado,
    CASE 
        WHEN s0 IS NULL AND v IS NOT NULL AND v0 IS NOT NULL AND s IS NOT NULL AND a IS NOT NULL THEN s - (v * v - v0 * v0) / (2 * a)
        ELSE s0
    END AS s0_calculado,
    CASE 
        WHEN a IS NULL AND v IS NOT NULL AND v0 IS NOT NULL AND s IS NOT NULL AND s0 IS NOT NULL THEN (v * v - v0 * v0) / (2 * (s - s0))
        ELSE a
    END AS a_calculado
FROM muv;

-- FIM da Equação de Torricelli --

-- FIM do Movimento Uniformemente Variado --

-- Criação das contas da variável faltante da Velocidade Média --

CREATE VIEW vm_calculos AS
SELECT *,
    CASE 
        WHEN s IS NULL AND s0 IS NOT NULL AND t IS NOT NULL AND t0 IS NOT NULL AND vm IS NOT NULL THEN s0 + vm * (t - t0)
        ELSE s
    END AS s_calculado,
    CASE 
        WHEN s0 IS NULL AND s IS NOT NULL AND t IS NOT NULL AND t0 IS NOT NULL AND vm IS NOT NULL THEN s - (vm * (t - t0))
        ELSE s0
    END AS s0_calculado,
    CASE 
        WHEN t IS NULL AND s IS NOT NULL AND s0 IS NOT NULL AND t0 IS NOT NULL AND vm IS NOT NULL THEN t0 + (s - s0) / vm
        ELSE t
    END AS t_calculado,
    CASE 
        WHEN t0 IS NULL AND s IS NOT NULL AND s0 IS NOT NULL AND t IS NOT NULL AND vm IS NOT NULL THEN t - (s - s0) / vm
        ELSE t0
    END AS t0_calculado,
    CASE 
        WHEN vm IS NULL AND s IS NOT NULL AND s0 IS NOT NULL AND t IS NOT NULL AND t0 IS NOT NULL THEN (s - s0) / (t - t0)
        ELSE vm
    END AS vm_calculado
FROM vm;

-- FIM da Velocidade Média --

-- Criação das contas da variável faltante da Aceleração Média --

CREATE VIEW am_calculos AS
SELECT *,
    CASE 
        WHEN v IS NULL AND v0 IS NOT NULL AND t IS NOT NULL AND t0 IS NOT NULL AND am IS NOT NULL THEN v0 + am * (t - t0)
        ELSE v
    END AS v_calculado,
    CASE 
        WHEN v0 IS NULL AND v IS NOT NULL AND t IS NOT NULL AND t0 IS NOT NULL AND am IS NOT NULL THEN v - am * (t - t0)
        ELSE v0
    END AS v0_calculado,
    CASE 
        WHEN t IS NULL AND v IS NOT NULL AND v0 IS NOT NULL AND t0 IS NOT NULL AND am IS NOT NULL THEN t0 + (v - v0) / am
        ELSE t
    END AS t_calculado,
    CASE 
        WHEN t0 IS NULL AND v IS NOT NULL AND v0 IS NOT NULL AND t IS NOT NULL AND am IS NOT NULL THEN t - (v - v0) / am
        ELSE t0
    END AS t0_calculado,
    CASE 
        WHEN am IS NULL AND v IS NOT NULL AND v0 IS NOT NULL AND t IS NOT NULL AND t0 IS NOT NULL THEN (v - v0) / (t - t0)
        ELSE am
    END AS am_calculado
FROM am;

-- FIM da Aceleração Média --

-- Criação das contas da variável faltante da Força / Segunda Lei de Newton --

CREATE VIEW forca_calculos AS
SELECT *,
    CASE 
        WHEN f IS NULL AND m IS NOT NULL AND a IS NOT NULL THEN m * a
        ELSE f
    END AS f_calculado,
    CASE 
        WHEN m IS NULL AND f IS NOT NULL AND a IS NOT NULL THEN f / a
        ELSE m
    END AS m_calculado,
    CASE 
        WHEN a IS NULL AND f IS NOT NULL AND m IS NOT NULL THEN f / m
        ELSE a
    END AS a_calculado
FROM forca;

-- Fim da Força / Segunda Lei de Newton --

create table calor(
q double null,
m double null,
c double null,
temp double null,
temp0 double null,
p double null,
t double null,
t0 double null
);

create table gas(
p double null,
v double null,
t double null,
p0 double null,
v0 double null,
t0 double null
);

create table ter(
u double null,
u0 double null,
q double null,
w double null
);

create table fe(
f double null,
q1 double null,
q2 double null,
d double null
);

create table ce(
i double null,
q double null,
q0 double null,
t double null,
t0 double null,
u double null,
r double null,
p double null
);

CREATE VIEW mct AS
SELECT *,
    CASE 
        WHEN q IS NULL AND m IS NOT NULL AND c IS NOT NULL AND temp IS NOT NULL AND temp0 IS NOT NULL THEN m * c * (temp - temp0)
        ELSE q
    END AS q_calculado,
    CASE 
        WHEN m IS NULL AND q IS NOT NULL AND c IS NOT NULL AND temp IS NOT NULL AND temp0 IS NOT NULL THEN (c * (temp - temp0)) / q
        ELSE m
    END AS m_calculado,
    CASE 
        WHEN c IS NULL AND q IS NOT NULL AND m IS NOT NULL AND temp IS NOT NULL AND temp0 IS NOT NULL THEN (m * (temp - temp0)) / q
        ELSE c
    END AS c_calculado,
    CASE 
        WHEN temp IS NULL AND q IS NOT NULL AND m IS NOT NULL AND c IS NOT NULL AND temp0 IS NOT NULL THEN temp0 + (q / (m * c))
        ELSE temp
    END AS temp_calculado,
    CASE 
        WHEN temp0 IS NULL AND q IS NOT NULL AND m IS NOT NULL AND c IS NOT NULL AND temp IS NOT NULL THEN temp - (q / (m * c))
        ELSE temp0
    END AS temp0_calculado
FROM calor;

CREATE VIEW pt AS
SELECT *,
    CASE 
        WHEN q IS NULL AND p IS NOT NULL AND t IS NOT NULL AND t0 IS NOT NULL THEN p * (t - t0)
        ELSE q
    END AS q_calculado,
    CASE 
        WHEN p IS NULL AND q IS NOT NULL AND t IS NOT NULL AND t0 IS NOT NULL THEN (t - t0) / q
        ELSE p
    END AS p_calculado,
    CASE 
        WHEN t IS NULL AND q IS NOT NULL AND p IS NOT NULL AND t0 IS NOT NULL THEN t0 + (q / p)
        ELSE t
    END AS t_calculado,
    CASE 
        WHEN t0 IS NULL AND q IS NOT NULL AND p IS NOT NULL AND t IS NOT NULL THEN t - (q / p)
        ELSE t0
    END AS t0_calculado
FROM calor;

CREATE VIEW pm AS
SELECT *,
    CASE 
        WHEN p IS NULL AND t IS NOT NULL AND t0 IS NOT NULL AND m IS NOT NULL AND c IS NOT NULL AND temp IS NOT NULL AND temp0 IS NOT NULL THEN m * c * (temp - temp0) / (t - t0)
        ELSE p
    END AS p_calculado,
    CASE 
        WHEN t IS NULL AND p IS NOT NULL AND t0 IS NOT NULL AND m IS NOT NULL AND c IS NOT NULL AND temp IS NOT NULL AND temp0 IS NOT NULL THEN t0 + m * c * (temp - temp0) / p
        ELSE t
    END AS t_calculado,
    CASE 
        WHEN t0 IS NULL AND p IS NOT NULL AND t IS NOT NULL AND m IS NOT NULL AND c IS NOT NULL AND temp IS NOT NULL AND temp0 IS NOT NULL THEN t - m * c * (temp - temp0) / p
        ELSE t0
    END AS t0_calculado,
    CASE 
        WHEN m IS NULL AND p IS NOT NULL AND t IS NOT NULL AND t0 IS NOT NULL AND c IS NOT NULL AND temp IS NOT NULL AND temp0 IS NOT NULL THEN  (p * (t - t0)) / (c * (temp - temp0))
        ELSE m
    END AS m_calculado,
    CASE 
        WHEN c IS NULL AND p IS NOT NULL AND t IS NOT NULL AND t0 IS NOT NULL AND m IS NOT NULL AND temp IS NOT NULL AND temp0 IS NOT NULL THEN  (p * (t - t0)) /(m * (temp - temp0))
        ELSE c
    END AS c_calculado,
    CASE 
        WHEN temp IS NULL AND p IS NOT NULL AND t IS NOT NULL AND t0 IS NOT NULL AND m IS NOT NULL AND c IS NOT NULL AND temp0 IS NOT NULL THEN temp0 + (p * (t - t0)) / (m * c)
        ELSE temp
    END AS temp_calculado,
    CASE 
        WHEN temp0 IS NULL AND p IS NOT NULL AND t IS NOT NULL AND t0 IS NOT NULL AND m IS NOT NULL AND c IS NOT NULL AND temp IS NOT NULL THEN temp - (p * (t - t0)) / (m * c)
        ELSE temp0
    END AS temp0_calculado
FROM calor;

CREATE VIEW gas_calculos AS
SELECT *,
    CASE 
        WHEN p IS NULL AND v IS NOT NULL AND t IS NOT NULL AND p0 IS NOT NULL AND v0 IS NOT NULL AND t0 IS NOT NULL THEN (p0 * v0 * t) / (t0 * v)
        ELSE p
    END AS p_calculado,
    CASE 
        WHEN v IS NULL AND p IS NOT NULL AND t IS NOT NULL AND p0 IS NOT NULL AND v0 IS NOT NULL AND t0 IS NOT NULL THEN (p0 * v0 * t) / (t0 * p)
        ELSE v
    END AS v_calculado,
    CASE 
        WHEN t IS NULL AND p IS NOT NULL AND v IS NOT NULL AND p0 IS NOT NULL AND v0 IS NOT NULL AND t0 IS NOT NULL THEN (p * v * t0) / (p0 * v0)
        ELSE t
    END AS t_calculado,
    CASE 
        WHEN p0 IS NULL AND p IS NOT NULL AND v IS NOT NULL AND t IS NOT NULL AND v0 IS NOT NULL AND t0 IS NOT NULL THEN (p * v * t0) / (t * v0)
        ELSE p0
    END AS p0_calculado,
    CASE 
        WHEN v0 IS NULL AND p IS NOT NULL AND v IS NOT NULL AND t IS NOT NULL AND p0 IS NOT NULL AND t0 IS NOT NULL THEN (p * v * t0) / (t * p0)
        ELSE v0
    END AS v0_calculado,
    CASE 
        WHEN t0 IS NULL AND p IS NOT NULL AND v IS NOT NULL AND t IS NOT NULL AND p0 IS NOT NULL AND v0 IS NOT NULL THEN (p0 * v0 * t) / (p * v)
        ELSE t0
    END AS t0_calculado
FROM gas;

CREATE VIEW ter_calculos AS
SELECT *,
    CASE 
        WHEN u IS NULL AND u0 IS NOT NULL AND q IS NOT NULL AND w IS NOT NULL THEN u0 + q - w
        ELSE u
    END AS u_calculado,
    CASE 
        WHEN u0 IS NULL AND u IS NOT NULL AND q IS NOT NULL AND w IS NOT NULL THEN u - q - w
        ELSE u0
    END AS u0_calculado,
    CASE 
        WHEN q IS NULL AND u IS NOT NULL AND u0 IS NOT NULL AND w IS NOT NULL THEN u0 - u - w
        ELSE q
    END AS q_calculado,
    CASE 
        WHEN w IS NULL AND q IS NOT NULL AND u IS NOT NULL AND u0 IS NOT NULL THEN u0 - u + q
        ELSE w
    END AS w_calculado
FROM ter;

CREATE VIEW fe_calculos AS
SELECT *,
    CASE 
        WHEN f IS NULL AND q1 IS NOT NULL AND q2 IS NOT NULL AND d IS NOT NULL THEN (9 * power(10, 9) * q1 * q2) / (d * d) 
        ELSE f
    END AS f_calculado,
    CASE 
        WHEN q1 IS NULL AND f IS NOT NULL AND q2 IS NOT NULL AND d IS NOT NULL THEN (f * d * d) / (9 * power(10, 9) * q2) 
        ELSE q1
    END AS q1_calculado,
    CASE 
        WHEN q2 IS NULL AND f IS NOT NULL AND q1 IS NOT NULL AND d IS NOT NULL THEN (f * d * d) / (9 * power(10, 9) * q1)
        ELSE q2
    END AS q2_calculado,
    CASE 
        WHEN d IS NULL AND f IS NOT NULL AND q1 IS NOT NULL AND q2 IS NOT NULL THEN sqrt(((9 * power(10, 9)) * q1 * q2) / f)
        ELSE d
    END AS d_calculado
FROM fe;

CREATE VIEW iqt AS
SELECT *,
    CASE 
        WHEN i IS NULL AND q IS NOT NULL AND q0 IS NOT NULL AND t IS NOT NULL AND t0 IS NOT NULL THEN (q - q0) / (t - t0)
        ELSE i
    END AS i_calculado,
    CASE 
        WHEN q IS NULL AND q0 IS NOT NULL AND t IS NOT NULL AND t0 IS NOT NULL AND i IS NOT NULL THEN q0 - i * (t - t0)
        ELSE q
    END AS q_calculado,
    CASE 
        WHEN q0 IS NULL AND q IS NOT NULL AND t IS NOT NULL AND t0 IS NOT NULL AND i IS NOT NULL THEN q - i * (t - t0)
        ELSE q0
    END AS q0_calculado,
    CASE 
        WHEN t IS NULL AND q IS NOT NULL AND q0 IS NOT NULL AND t0 IS NOT NULL AND i IS NOT NULL THEN t0 + (q - q0) / i
        ELSE t
    END AS t_calculado,
    CASE 
        WHEN t0 IS NULL AND q IS NOT NULL AND q0 IS NOT NULL AND t IS NOT NULL AND i IS NOT NULL THEN t - (q - q0) / i
        ELSE t0
    END AS t0_calculado
FROM ce;

CREATE VIEW uri AS
SELECT *,
    CASE 
        WHEN u IS NULL AND r IS NOT NULL AND i IS NOT NULL THEN r * i
        ELSE u
    END AS u_calculado,
    CASE 
        WHEN r IS NULL AND u IS NOT NULL AND i IS NOT NULL THEN u / i
        ELSE r
    END AS r_calculado,
    CASE 
        WHEN i IS NULL AND u IS NOT NULL AND r IS NOT NULL THEN u / r
        ELSE i
    END AS i_calculado
FROM ce;

CREATE VIEW pui AS
SELECT *,
    CASE 
        WHEN u IS NULL AND p IS NOT NULL AND i IS NOT NULL THEN p / i
        ELSE u
    END AS u_calculado,
    CASE 
        WHEN p IS NULL AND u IS NOT NULL AND i IS NOT NULL THEN u * i
        ELSE p
    END AS p_calculado,
    CASE 
        WHEN i IS NULL AND u IS NOT NULL AND p IS NOT NULL THEN p / u
        ELSE i
    END AS i_calculado
FROM ce;

create table cm(
b double null,
μ double null,
i double null,
r double null,
l double null,
n double null
);

create table fm(
f double null,
b double null,
q double null,
v double null,
θ double null,
i double null,
i2 double null,
i3 double null,
l double null,
d double null,
μ double null
);

CREATE OR REPLACE VIEW f AS
SELECT *,
    CASE 
        WHEN b IS NULL AND μ IS NOT NULL AND i IS NOT NULL AND r IS NOT NULL THEN (μ * i) / (2 * PI() * r)
        ELSE b
    END AS b_calculado,
    CASE 
        WHEN μ IS NULL AND b IS NOT NULL AND i IS NOT NULL AND r IS NOT NULL THEN (b * 2 * PI() * r) / i
        ELSE μ
    END AS μ_calculado,
    CASE
        WHEN i IS NULL AND b IS NOT NULL AND μ IS NOT NULL AND r IS NOT NULL THEN (b * 2 * PI() * r) / μ
        ELSE i
    END AS i_calculado,
    CASE
        WHEN r IS NULL AND b IS NOT NULL AND μ IS NOT NULL AND i IS NOT NULL THEN (μ * i) / (2 * PI() * b)
        ELSE r
    END AS r_calculado
FROM cm;

CREATE OR REPLACE VIEW ec AS
SELECT *,
    CASE 
        WHEN b IS NULL AND μ IS NOT NULL AND i IS NOT NULL AND r IS NOT NULL THEN (μ * i) / (2 * r)
        ELSE b
    END AS b_calculado,
    CASE 
        WHEN μ IS NULL AND b IS NOT NULL AND i IS NOT NULL AND r IS NOT NULL THEN (b * 2 * r) / i
        ELSE μ
    END AS μ_calculado,
    CASE
        WHEN i IS NULL AND b IS NOT NULL AND μ IS NOT NULL AND r IS NOT NULL THEN (b * 2 * r) / μ
        ELSE i
    END AS i_calculado,
    CASE
        WHEN r IS NULL AND b IS NOT NULL AND μ IS NOT NULL AND i IS NOT NULL THEN (μ * i) / (2 * b)
        ELSE r
    END AS r_calculado
FROM cm;

CREATE OR REPLACE VIEW b AS
SELECT *,
    CASE 
        WHEN b IS NULL AND μ IS NOT NULL AND i IS NOT NULL AND r IS NOT NULL AND n IS NOT NULL THEN (μ * i * n ) / (2 * r)
        ELSE b
    END AS b_calculado,
    CASE 
        WHEN μ IS NULL AND b IS NOT NULL AND i IS NOT NULL AND r IS NOT NULL AND n IS NOT NULL THEN (b * 2 * r) / (i * n)
        ELSE μ
    END AS μ_calculado,
    CASE
        WHEN i IS NULL AND b IS NOT NULL AND μ IS NOT NULL AND r IS NOT NULL AND n IS NOT NULL THEN (b * 2 * r) / (μ * n)
        ELSE i
    END AS i_calculado,
    CASE
        WHEN r IS NULL AND b IS NOT NULL AND μ IS NOT NULL AND i IS NOT NULL AND n IS NOT NULL THEN (n * μ * i) / (2 * b)
        ELSE r
    END AS r_calculado,
    CASE
        WHEN n IS NULL AND b IS NOT NULL AND μ IS NOT NULL AND i IS NOT NULL AND r IS NOT NULL THEN (2 * r * b) / (μ * i)
        ELSE n
    END AS n_calculado
FROM cm;

CREATE OR REPLACE VIEW s AS
SELECT *,
    CASE 
        WHEN b IS NULL AND μ IS NOT NULL AND i IS NOT NULL AND l IS NOT NULL AND n IS NOT NULL THEN (μ * i * n) / l
        ELSE b
    END AS b_calculado,
    CASE 
        WHEN μ IS NULL AND b IS NOT NULL AND i IS NOT NULL AND l IS NOT NULL AND n IS NOT NULL THEN (b * l) / (i * n)
        ELSE μ
    END AS μ_calculado,
    CASE
        WHEN i IS NULL AND b IS NOT NULL AND μ IS NOT NULL AND l IS NOT NULL AND n IS NOT NULL THEN (b * l) / (μ * n)
        ELSE i
    END AS i_calculado,
    CASE
        WHEN l IS NULL AND b IS NOT NULL AND μ IS NOT NULL AND i IS NOT NULL AND n IS NOT NULL THEN (μ * i * n) / b
        ELSE l
    END AS l_calculado,
    CASE
        WHEN n IS NULL AND b IS NOT NULL AND μ IS NOT NULL AND i IS NOT NULL AND l IS NOT NULL THEN (b * l) / (μ * i)
        ELSE n
    END AS n_calculado
FROM cm;

CREATE OR REPLACE VIEW pc AS
SELECT *,
    CASE 
        WHEN f IS NULL AND b IS NOT NULL AND q IS NOT NULL AND v IS NOT NULL AND θ IS NOT NULL  THEN round((b * q * v) * SIN(RADIANS(θ)))
        ELSE f
    END AS f_calculado,
    CASE 
        WHEN v IS NULL AND b IS NOT NULL AND q IS NOT NULL AND f IS NOT NULL AND θ IS NOT NULL AND NULLIF(b * q * SIN(RADIANS(θ)), 0) IS NOT NULL THEN  round(f / (b * q * SIN(RADIANS(θ))))
        ELSE v
    END AS v_calculado,
    CASE 
        WHEN q IS NULL AND b IS NOT NULL AND f IS NOT NULL AND v IS NOT NULL AND θ IS NOT NULL AND NULLIF(b * v * SIN(RADIANS(θ)), 0) IS NOT NULL THEN  round(f / (b * v * SIN(RADIANS(θ))))
        ELSE q
    END AS q_calculado,
    CASE 
        WHEN b IS NULL  AND f IS NOT NULL AND q IS NOT NULL AND v IS NOT NULL AND θ IS NOT NULL AND NULLIF(q * v * SIN(RADIANS(θ)), 0) IS NOT NULL THEN round(f / (q * v * SIN(RADIANS(θ))))
        ELSE b
    END AS b_calculado,
    CASE 
        WHEN θ IS NULL  AND f IS NOT NULL AND q IS NOT NULL AND v IS NOT NULL AND b IS NOT NULL AND NULLIF(b * q * v, 0) AND ABS(f / (b * q * v)) <= 1 IS NOT NULL THEN round(ASIN(f / (b * q * v)) * 180 / PI())
        ELSE θ
    END AS θ_calculado
FROM fm;

CREATE OR REPLACE VIEW fc AS
SELECT *,
    CASE 
        WHEN f IS NULL AND b IS NOT NULL AND i IS NOT NULL AND l IS NOT NULL AND θ IS NOT NULL THEN ROUND((b * i * l) * SIN(RADIANS(θ)))
        ELSE f
    END AS f_calculado,
    CASE 
        WHEN i IS NULL AND b IS NOT NULL AND f IS NOT NULL AND l IS NOT NULL AND θ IS NOT NULL AND NULLIF(b * l * SIN(RADIANS(θ)), 0) IS NOT NULL THEN ROUND(f / (b * l * SIN(RADIANS(θ))))
        ELSE i
    END AS i_calculado,
    CASE 
        WHEN l IS NULL AND b IS NOT NULL AND f IS NOT NULL AND i IS NOT NULL AND θ IS NOT NULL AND NULLIF(b * i * SIN(RADIANS(θ)), 0) IS NOT NULL THEN ROUND(f / (b * i * SIN(RADIANS(θ))))
        ELSE l
    END AS l_calculado,
    CASE 
        WHEN b IS NULL AND f IS NOT NULL AND i IS NOT NULL AND l IS NOT NULL AND θ IS NOT NULL AND NULLIF(i * l * SIN(RADIANS(θ)), 0) IS NOT NULL THEN ROUND(f / (i * l * SIN(RADIANS(θ))))
        ELSE b
    END AS b_calculado,
    CASE 
        WHEN θ IS NULL AND f IS NOT NULL AND b IS NOT NULL AND i IS NOT NULL AND l IS NOT NULL AND NULLIF(b * i * l, 0) IS NOT NULL AND ABS(f / (b * i * l)) <= 1 THEN ROUND(ASIN(f / (b * i * l)) * 180 / PI())
        ELSE θ
    END AS θ_calculado
FROM fm;

CREATE OR REPLACE VIEW fp AS
SELECT *,
    CASE 
        WHEN f IS NULL AND μ IS NOT NULL AND i IS NOT NULL AND i2 IS NOT NULL AND l IS NOT NULL AND d IS NOT NULL AND NULLIF(2 * PI() * d, 0) IS NOT NULL THEN (μ * i * i2 * l) / (2 * PI() * d)
        ELSE f
    END AS f_calculado,
    CASE
        WHEN μ IS NULL AND f IS NOT NULL AND i IS NOT NULL AND i2 IS NOT NULL AND l IS NOT NULL AND d IS NOT NULL AND NULLIF(i * i2 * l, 0) IS NOT NULL THEN (2 * PI() * d * f) / (i * i2 * l)
        ELSE μ
    END AS μ_calculado,
    CASE
        WHEN i IS NULL AND f IS NOT NULL AND μ IS NOT NULL AND i2 IS NOT NULL AND l IS NOT NULL AND d IS NOT NULL AND NULLIF(μ * i2 * l, 0) IS NOT NULL THEN (2 * PI() * d * f) / (μ * i2 * l)
        ELSE i
    END AS i1_calculado,
    CASE
        WHEN i2 IS NULL AND f IS NOT NULL AND μ IS NOT NULL AND i IS NOT NULL AND l IS NOT NULL AND d IS NOT NULL AND NULLIF(μ * i * l, 0) IS NOT NULL THEN (2 * PI() * d * f) / (μ * i * l)
        ELSE i2
    END AS i2_calculado,
    CASE
        WHEN l IS NULL AND f IS NOT NULL AND μ IS NOT NULL AND i IS NOT NULL AND i2 IS NOT NULL AND d IS NOT NULL AND NULLIF(μ * i * i2, 0) IS NOT NULL THEN (2 * PI() * d * f) / (μ * i * i2)
        ELSE l
    END AS l_calculado,
    CASE
        WHEN d IS NULL AND f IS NOT NULL AND μ IS NOT NULL AND i IS NOT NULL AND i2 IS NOT NULL AND l IS NOT NULL AND NULLIF(2 * PI() * f, 0) IS NOT NULL THEN (μ * i * i2 * l) / (2 * PI() * f)
        ELSE d
    END AS d_calculado
FROM fm; 

create table im(
Φ double null,
Φ₀ double null,
b double null,
a double null,
alpha double null,
ε double null,
t double null,
t0 double null,
u1 double null,
u2 double null,
n1 double null,
n2 double null,
p1 double null,
p2 double null,
i1 double null,
i2 double null
);

CREATE OR REPLACE VIEW fom AS
SELECT *,
    CASE 
        WHEN Φ IS NULL AND b IS NOT NULL AND a IS NOT NULL AND alpha IS NOT NULL THEN ROUND(b * a * COS(RADIANS(alpha)), 6)
        ELSE Φ
    END AS Φ_calculado,
    CASE 
        WHEN b IS NULL AND Φ IS NOT NULL AND a IS NOT NULL AND alpha IS NOT NULL AND NULLIF(a * COS(RADIANS(alpha)), 0) IS NOT NULL THEN ROUND(Φ / (a * COS(RADIANS(alpha))), 6)
        ELSE b
    END AS b_calculado,
    CASE 
        WHEN a IS NULL AND Φ IS NOT NULL AND b IS NOT NULL AND alpha IS NOT NULL AND NULLIF(b * COS(RADIANS(alpha)), 0) IS NOT NULL THEN ROUND(Φ / (b * COS(RADIANS(alpha))), 6)
        ELSE a
    END AS a_calculado,
    CASE 
        WHEN alpha IS NULL AND Φ IS NOT NULL AND b IS NOT NULL AND a IS NOT NULL AND NULLIF(b * a, 0) IS NOT NULL THEN ROUND(ACOS(Φ / (b * a)) * 180 / PI(), 6)
        ELSE alpha
    END AS alpha_calculado
FROM im;

CREATE OR REPLACE VIEW lf AS
SELECT *,
    CASE 
        WHEN ε IS NULL AND Φ IS NOT NULL AND Φ₀ IS NOT NULL AND t IS NOT NULL AND t0 IS NOT NULL AND NULLIF(t - t0, 0) IS NOT NULL THEN -(Φ - Φ₀) / (t - t0)
        ELSE ε
    END AS ε_calculado,
    CASE 
        WHEN Φ IS NULL AND ε IS NOT NULL AND Φ₀ IS NOT NULL AND t IS NOT NULL AND t0 IS NOT NULL THEN Φ₀ - (ε * (t - t0))
        ELSE Φ
    END AS Φ_calculado,
    CASE 
        WHEN Φ₀ IS NULL AND ε IS NOT NULL AND Φ IS NOT NULL AND t IS NOT NULL AND t0 IS NOT NULL THEN Φ + (ε * (t - t0))
        ELSE Φ₀
    END AS Φ₀_calculado,
    CASE 
        WHEN t IS NULL AND ε IS NOT NULL AND Φ IS NOT NULL AND Φ₀ IS NOT NULL AND NULLIF(ε, 0) IS NOT NULL THEN t0 - ((Φ - Φ₀) / ε)
        ELSE t
    END AS t_calculado,
    CASE
    WHEN t0 IS NULL AND ε IS NOT NULL AND Φ IS NOT NULL AND Φ₀ IS NOT NULL AND NULLIF(ε, 0) IS NOT NULL THEN t + ((Φ - Φ₀) / ε)
        ELSE t0
    END AS t0_calculado
FROM im;

CREATE OR REPLACE VIEW t AS
SELECT *,
    CASE 
        WHEN u2 IS NULL AND u1 IS NOT NULL AND n1 IS NOT NULL AND n2 IS NOT NULL AND NULLIF(n2, 0) IS NOT NULL THEN u1 * n2 / n1
        ELSE u2
    END AS u2_calculado,
    CASE 
        WHEN u1 IS NULL AND u2 IS NOT NULL AND n1 IS NOT NULL AND n2 IS NOT NULL AND NULLIF(n1, 0) IS NOT NULL THEN u2 * n1 / n2
        ELSE u1
    END AS u1_calculado,
    CASE 
        WHEN n2 IS NULL AND u1 IS NOT NULL AND u2 IS NOT NULL AND n1 IS NOT NULL AND NULLIF(u1, 0) IS NOT NULL THEN u2 * n1 / u1
        ELSE n2
    END AS n2_calculado,
    CASE 
        WHEN n1 IS NULL AND u1 IS NOT NULL AND u2 IS NOT NULL AND n2 IS NOT NULL AND NULLIF(u2, 0) IS NOT NULL THEN u1 * n2 / u2
        ELSE n1
    END AS n1_calculado
FROM im;

CREATE OR REPLACE VIEW tp AS
SELECT *,
    CASE
        WHEN u1 IS NOT NULL THEN u1 WHEN i1 IS NOT NULL AND u2 IS NOT NULL AND i2 IS NOT NULL THEN (u2 * i2) / i1
        ELSE NULL
    END AS u1_calculado,
    CASE
        WHEN i1 IS NOT NULL THEN i1 WHEN u1 IS NOT NULL AND u2 IS NOT NULL AND i2 IS NOT NULL THEN (u2 * i2) / u1
        ELSE NULL
    END AS i1_calculado,
    CASE
        WHEN u2 IS NOT NULL THEN u2 WHEN i2 IS NOT NULL AND u1 IS NOT NULL AND i1 IS NOT NULL THEN (u1 * i1) / i2
        ELSE NULL
    END AS u2_calculado,
    CASE
        WHEN i2 IS NOT NULL THEN i2 WHEN u2 IS NOT NULL AND u1 IS NOT NULL AND i1 IS NOT NULL THEN (u1 * i1) / u2
        ELSE NULL
    END AS i2_calculado
FROM im;