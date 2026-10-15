# Random Forest
# Nesta tarefa, vocês vão trabalhar com uma base de dados de avaliações de vinhos, 
# onde o objetivo é prever a pontuação dos vinhos usando o algoritmo de Random Forest 
# para classificação multiclasse.

from imblearn.over_sampling import SMOTE
from scipy.stats import zscore
from sklearn.ensemble import RandomForestClassifier
from sklearn.metrics import accuracy_score, classification_report, confusion_matrix
from sklearn.model_selection import train_test_split
from sklearn.model_selection import RandomizedSearchCV
import matplotlib.pyplot as plt
import numpy as np
import pandas as pd
import seaborn as sns


df = pd.read_csv("winequality-red.csv", delimiter=',')
df.head(10)

# Características dos Vinhos (Features)
# 
# Fixed Acidity: Acidez fixa do vinho.
# 
# Volatile Acidity: Acidez volátil do vinho.
# 
# Citric Acid: Quantidade de ácido cítrico no vinho.
# 
# Residual Sugar: Açúcar residual presente no vinho.
# 
# Chlorides: Nível de cloretos no vinho.
# 
# Free Sulfur Dioxide: Dióxido de enxofre livre no vinho.
# 
# Total Sulfur Dioxide: Quantidade total de dióxido de enxofre no vinho.
# 
# Density: Densidade do vinho.
# 
# pH: Nível de pH do vinho.
# 
# Sulphates: Quantidade de sulfatos no vinho.
# 
# Alcohol: Teor alcoólico do vinho.
# 
# **Variável de Saída (Target):**
# 
# Quality: Pontuação do vinho baseada em dados sensoriais, variando de 0 a 10.


# 1 - Pré processamento dos dados.
print(df.info())

print(df.describe())

# Remover outliers de residual sugar, free sulfur dioxide e total dioxide
df["sugar_z"] = zscore(df["residual sugar"])
df["free_sulfur_z"] = zscore(df["free sulfur dioxide"])
df["total_sulfur_z"] = zscore(df["total sulfur dioxide"])

df_filtrado = df[
    (df["sugar_z"] <= 3)
    & (df["free_sulfur_z"] <= 3)
    & (df["total_sulfur_z"] <= 3)
]
print(df_filtrado.shape)

df_filtrado = df_filtrado.drop(columns=["sugar_z", "free_sulfur_z", "total_sulfur_z"])
print(df_filtrado.shape)


fig, axes = plt.subplots(1, 3, figsize=(12, 5))

# Residual sugar
sns.boxplot(df_filtrado, y="residual sugar", ax=axes[0])
axes[0].set_title("Açúcar Residual")

# free sulfur dioxide
sns.boxplot(df_filtrado, y="free sulfur dioxide", ax=axes[1])
axes[1].set_title("Dióxido de Enxofre")

# total sulfur dioxide
sns.boxplot(df_filtrado, y="total sulfur dioxide", ax=axes[2])
axes[2].set_title("Dióxido de Enxofre Total")

plt.show()

print(df.quality.value_counts())

fig = plt.figure(figsize=(8, 5))
sns.heatmap(df_filtrado.corr(), annot=True, fmt=".2f", cmap="Blues")
plt.show()

# Todas as variáveis serão mantidas, pois tem boas correlações ou entre elas 
# ou com a variável alvo diretamente.
df_resumido = df_filtrado.drop(columns=["residual sugar", "chlorides", 
                                        "free sulfur dioxide", "total sulfur dioxide"])


# 2 - Separação dos Dados
X = df_filtrado.drop("quality", axis=1)
y = df_filtrado.quality

X_train, X_test, y_train, y_test = train_test_split(
    X, y, random_state=987, test_size=0.25, stratify=y
)
print(X_train.shape, X_test.shape, y_train.shape, y_test.shape)

print("Quantidade de classes alvo:\n", y_train.value_counts())


# 3 - Modelagem
rf = RandomForestClassifier()
rf.fit(X_train, y_train)

y_pred = rf.predict(X_test)


# 4 - Avaliação
print(classification_report(y_test, y_pred))


# 5 - Melhorando os Hyperparametros
# Essa parte demorará um pouco para rodar.
params = {
    "n_estimators": [100, 150, 200], 
    "criterion": ["gini", "entropy"], 
    "max_depth": [None, 10, 25, 50], 
    "min_samples_split": [2, 5, 10], 
    "min_samples_leaf": [1, 2, 4], 
    "max_features": [None, "sqrt", "log2"], 
}
random_search = RandomizedSearchCV(rf, params, n_iter=50, scoring="accuracy", cv=5, random_state=987)

random_search.fit(X_train, y_train)
print(random_search)

random_search.best_estimator_.fit(X_train, y_train)
y_pred = random_search.best_estimator_.predict(X_test)

print("Reporte ajustado:")
print(classification_report(y_test, y_pred))

# O resultado da acurácia praticamente não mudou, uma queda de 1% apenas. 
# Individualmente a classe 4, que estava zerada melhorou fazendo alguns acertos; 
# porém as classes com poucos dados, 3 e 8, continuaram sem nenhum acerto obtido.

"""
As classes estavam desbalanceadas, então para tentar melhorar o resultado 
será refeito o treinamento com o dataset balanceado.
"""
# Balanceamento das classes de treino
smote = SMOTE()
X_train_balanced, y_train_balanced = smote.fit_resample(X_train, y_train)
print(y_train_balanced.value_counts())

print(X_train_balanced.shape, y_train_balanced.shape)

random_search.fit(X_train_balanced, y_train_balanced)
random_search.best_estimator_.fit(X_train_balanced, y_train_balanced)
y_pred = random_search.best_estimator_.predict(X_test)

print(classification_report(y_test, y_pred))

# Com o balanceamento das classes as classes com pouca representação 
# tiveram alguma melhoria, apenas a classe 8 permanecendo sem acertos.

a = df_resumido.drop("quality", axis=1)
b = df_resumido.quality

atr, att, btr, btt = train_test_split(a, b, test_size=0.25, random_state=42)
random_search.fit(atr, btr)
bpr = random_search.best_estimator_.predict(att)
print(classification_report(btt, bpr))

atb, btb = smote.fit_resample(atr, btr)
random_search.fit(atb, btb)
bpr = random_search.best_estimator_.predict(att)
print(classification_report(btt, bpr))


