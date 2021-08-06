import React from 'react'
import { Container } from './styled'

export default function Content(props) {
    return (
        <Container>
            {props.children}
        </Container>
    )
}
