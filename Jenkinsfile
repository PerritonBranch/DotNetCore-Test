pipeline {
  agent {
    docker {
      image 'node:6-alpine'
      args '''-p 3000:3000
-v /var/run/docker.sock:/var/run/docker.sock'''
    }

  }
  stages {
    stage('TestDockerCommands') {
      steps {
        sh 'cat /etc/*-release'
        sh 'whoami'
        sh 'docker ps'
        sh 'docker --version'
        sh 'docker run hello world'
      }
    }
  }
}