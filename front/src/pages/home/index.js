import React from 'react'
import Content from '../../components/content'
import Header from '../../components/header'
import { Container, Entrar } from './styled'

export default function Home() {
    return (
        <Container>
            <Header />
            <Content>
                <Entrar className="btn btn-outline-secondary">
                    <p>
                        Entrar
                    </p>
                </Entrar>
            </Content>
        </Container>
    )
}
