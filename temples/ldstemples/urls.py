from django.urls import path
from . import views

urlpatterns = [
    path('', views.home, name='home'),
    path('templelist/', views.templelist, name='templelist'),
    path('temple/<int:temple_id>/', views.temple, name='temple'),
    path('templeshow/<int:temple_id>/', views.templeshow, name='templeshow'),
]
