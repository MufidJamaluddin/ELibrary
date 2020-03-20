import React from 'react';
import { render } from '@testing-library/react';
import '@testing-library/jest-dom/extend-expect';
import Home from './Home';

test('renders smart library text', () => {
  const { getByText } = render(<Home />);
  const textElement = getByText(/Book List/i);
  expect(textElement).toBeInTheDocument();
});